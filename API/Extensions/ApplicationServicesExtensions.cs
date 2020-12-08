using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Interfaces;
using API.Services;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config) 
        {
            services.AddDbContext<DataContext>(options =>
           {
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
           });
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}