using FHB_BLL.Mapping;
namespace FITHUB_WEB_API.Extensions
{
    public static class AutoMapperExtension
    {

        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;

        }


    }
}
