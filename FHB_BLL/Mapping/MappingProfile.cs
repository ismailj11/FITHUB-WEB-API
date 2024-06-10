using AutoMapper;
using FHB_BLL.DTO.Categories;
using FHB_BLL.DTO.CategoryWithProductDto;
using FHB_BLL.DTO.Employees;
using FHB_BLL.DTO.Members;
using FHB_BLL.DTO.ProductsDto;
using FHB_BLL.DTO.Tenants;
using FHB_BLL.DTO.UserDto;
using FHB_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHB_BLL.DTO.CategoryWithProductDto;

namespace FHB_BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tenant, TenantDto>().ReverseMap();



            CreateMap<Category, CategoryDto>().ReverseMap();


            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<Member, MemberDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDto>();

            
            CreateMap<CategoryWithProductsDto,IEnumerable<ProductDto>>();

        }
    }
}
