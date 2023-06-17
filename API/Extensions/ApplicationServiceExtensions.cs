using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection addApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt => 
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection")); //Lifetime.scopet - lifetime of the request
            }); //options are passed into a function
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>(); //it will work if we add only the service ex : <TokenService>(); but advantage of using interface is when it comes to testing our code. with interface you isolate what you are going to test

            return services;
        }
    }
}