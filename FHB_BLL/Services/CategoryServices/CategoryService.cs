using AutoMapper;
using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.CategoryWithProductDto;
using FHB_BLL.DTO.ProductsDto;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using FHB_DAL.Repositories.Categories;
using FHB_DAL.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace FHB_BLL.Services.CategoryServices
{
    public class CategoryService : GenericService<Category, CategoryDto>, ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository, IProductRepository productRepository)
            : base(categoryRepository, mapper)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public ApiResponse<CategoryDto> GetCategoryByName(string name)
        {
            var response = new ApiResponse<CategoryDto>();
            var result = _categoryRepository.GetCategoryByName(name);
            response.Data = _mapper.Map<CategoryDto>(result);
            return response;
        }

        public ApiResponse<CategoryWithProductsDto> AddCategoryWithProducts(CategoryWithProductsDto dto)
        {
            var response = new ApiResponse<CategoryWithProductsDto>();

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (string.IsNullOrEmpty(dto.CategoryName))
                    {
                        response.Success = false;
                        response.ErrorMessage = "Category name is null or empty";
                        return response;
                    }

                    // Add the category
                    var category = new Category { CategoryName = dto.CategoryName };
                    _categoryRepository.Add(category);
                   
                    // Get the generated CategoryId
                    int categoryId = category.CategoryId;

                    // Map the products and set the foreign key
                    var products = _mapper.Map<List<Product>>(dto.Products);
                    foreach (var product in products)
                    {
                        // Check if the price is less than zero
                        if (product.Price < 0)
                        {
                            response.Errors.Add($"Product price for '{product.ProductName}' cannot be less than zero");
                            response.Success = false;
                            throw new Exception($"Product price for '{product.ProductName}' cannot be less than zero");
                        }

                        product.FkCategoryId = categoryId; // Set the foreign key
                        _productRepository.Add(product);
                    }

                   

                    // Mark the transaction as complete
                    scope.Complete();

                    // Map back to DTOs to include the generated IDs
                    var createdCategoryDto = _mapper.Map<CategoryWithProductsDto>(category);
                    createdCategoryDto.Products = _mapper.Map<List<ProductDto>>(products);

                    response.Data = createdCategoryDto;
                    response.Success = true;
                }
                catch (Exception ex)
                {
                    // Any exceptions will automatically trigger a rollback when scope.Complete() is not called
                    response.Success = false;
                    response.ErrorMessage = "An error occurred while adding the category and products";
                    response.Errors.Add(ex.Message);
                }
            }

            return response;
        }
    }
}