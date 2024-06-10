using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.CategoryWithProductDto;
using FHB_BLL.DTO.Employees;
using FHB_BLL.Services.CategoryServices;
using FHB_BLL.Services.EmployeeServices;
using FHB_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FITHUB_WEB_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CategoryController : GenericController<CategoryDto>
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService service) : base(service)
        {
            _categoryService = service;
        }

        [HttpGet("GetCategoryByName")]
        public ApiResponse<CategoryDto> GetCategoryByNames(string name)
        {
            return _categoryService.GetCategoryByName(name);


        }


        [HttpPost("AddCategoryWithProducts")]
        public ActionResult<ApiResponse<CategoryWithProductsDto>> Add(CategoryWithProductsDto dto)
        {
            var response = _categoryService.AddCategoryWithProducts(dto);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}

