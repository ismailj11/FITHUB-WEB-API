using FHB_BLL.Services.AuthenticationServices;
using FHB_BLL.Services.CategoryServices;

using FHB_BLL.Services.EmployeeServices;
using FHB_BLL.Services.MemberServices;
using FHB_BLL.Services.ProductServices;
using FHB_BLL.Services.TenantServices;
using FHB_BLL.Services.UserServices;
using Microsoft.Extensions.DependencyInjection;

namespace FITHUB_WEB_API.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceExtension(this IServiceCollection services)
        {
            services.AddScoped<ITenantService, TenantService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IAuthService, AuthService>();
           
            
            return services;
        }
    }
}