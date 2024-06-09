using FHB_BLL.DTO.ProductsDto;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.Services.ProductServices;
using FHB_BLL.Services.TenantServices;
using FHB_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace FITHUB_WEB_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : GenericController<ProductDto>
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService service) : base(service)
        {
            _productService = service;
        }

        [HttpGet("GetProductByProductName")]
        public ApiResponse<ProductDto> GetProductByProductNames(string name)
        {
            return _productService.GetProductByProductName(name);
        }



        [HttpGet("GetProductByCategoryID")]
        public ApiResponse<IEnumerable<ProductDto>> GetProductsByCategoryID(int id)
        {
            return _productService.GetProductByCategoryID(id);
        }

    }
}
