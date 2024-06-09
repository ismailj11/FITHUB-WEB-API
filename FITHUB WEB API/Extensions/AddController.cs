
using FITHUB_WEB_API.Filters;
namespace FITHUB_WEB_API.Extensions

{
    public static class AddControllers
    {

        public static IServiceCollection AddController(this IServiceCollection Services)
        {
            Services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return Services;
        }
    }
}
