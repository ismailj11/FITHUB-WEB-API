using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHB_BLL.DTO.ProductsDto
{
    public class ProductDto
    {

        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public double? Price { get; set; }

        public double? Weight { get; set; }

        public int? Quantity { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public int? FkCategoryId { get; set; }


    }
}
