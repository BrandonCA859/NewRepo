using DataAccess.Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ISvUser, SvUser>();
            services.AddScoped<ISvCategory, SvCategory>();
            services.AddScoped<ISvOrder, SvOrder>();
            services.AddScoped<ISvCart, SvCart>();
            services.AddScoped<ISvShipping, SvShipping>();
            services.AddScoped<ISvProducts, SvProducts>();
            return services;
        }

    }
}
