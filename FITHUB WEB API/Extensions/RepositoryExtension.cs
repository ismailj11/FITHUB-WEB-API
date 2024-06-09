using FHB_DAL.Repositories.Categories;
using FHB_DAL.Repositories.Employees;
using FHB_DAL.Repositories.Members;
using FHB_DAL.Repositories.Products;
using FHB_DAL.Repositories.Tenants;
using FHB_DAL.Repositories.Users;
using System.Reflection.Metadata.Ecma335;
namespace FITHUB_WEB_API.Extensions
{
    public static class repositoryExtension
    {

        public static IServiceCollection AddRepositories(this IServiceCollection Services)
        {
            Services.AddScoped<ITenantRepository,TenantRepository>();
            Services.AddScoped<ICategoryRepository,CategoryRepository>();
            Services.AddScoped<IUserRepository, UserRepository>();
            Services.AddScoped<IProductRepository, ProductRepository>();
            Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            Services.AddScoped<IMemberRepository, MemberRepository>();


            return Services;
        }



    }
}
