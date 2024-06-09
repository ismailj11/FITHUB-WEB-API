using System;
using System.Collections.Generic;
using FHB_BLL.DTO.ProductsDto;
using Microsoft.IdentityModel.Tokens;  // Ensure this is included

namespace FHB_BLL.DTO.CategoryWithProductDto
{
    public class CategoryWithProductsDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();

      
    }
}