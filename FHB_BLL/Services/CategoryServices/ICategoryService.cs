using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.CategoryWithProductDto;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.Services.GenericServices;
using FHB_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.Services.CategoryServices
{
    public interface ICategoryService : IGenericService<CategoryDto>
    {
        
        
        
      

        ApiResponse<CategoryDto> GetCategoryByName(string name);
        ApiResponse<CategoryWithProductsDto> AddCategoryWithProducts(CategoryWithProductsDto dto);

    }
}
