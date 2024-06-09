using FHB_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FITHUB_WEB_API.Extensions
{
    public static class StartUpExtension
    {

        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {

            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<FithubDbContext>(options =>
                            options.UseSqlServer(ConnectionString)

                            );


            return service;




        }


    }
}
