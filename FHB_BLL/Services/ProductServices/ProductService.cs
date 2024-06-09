using AutoMapper;
using FHB_BLL.DTO.ProductsDto;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Services.TenantServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using FHB_DAL.Repositories.Products;
using FHB_DAL.Repositories.Tenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.ProductServices
{
    public class ProductService : GenericService<Product, ProductDto>, IProductService
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper) : base(productRepository, mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public ApiResponse<ProductDto> GetProductByProductName(string name)
        {
            var response = new ApiResponse<ProductDto>();
            var result = _productRepository.GetProductByProductName(name);
            response.Data = _mapper.Map<ProductDto>(result);
            return response;
        }

        public ApiResponse<IEnumerable<ProductDto>> GetProductByCategoryID(int categoryID)
        {
            var response = new ApiResponse<IEnumerable<ProductDto>>();
            var result = _productRepository.GetProductByCategoryID(categoryID);
            response.Data = _mapper.Map<IEnumerable<ProductDto>>(result);
            return response;
        }


    }
}
