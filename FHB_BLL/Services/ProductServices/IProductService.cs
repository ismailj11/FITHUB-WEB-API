using FHB_BLL.DTO.ProductsDto;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using FHB_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.ProductServices
{
    public interface IProductService : IGenericService<ProductDto>
    {
        ApiResponse<ProductDto> GetProductByProductName(string name);
        ApiResponse<IEnumerable<ProductDto>> GetProductByCategoryID(int categoryID);

    }
}
