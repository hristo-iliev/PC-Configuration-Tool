using Microsoft.Extensions.DependencyInjection;
using PCConfiguration.Core.Services;
using PCConfiguration.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCConfiguration.Core
{
    public static class ServiceRegister
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IPCConfigurationUoW, PCConfigurationUoW>();
            services.AddScoped<IPCConfigurationService, PCConfigurationService>();
            services.AddScoped<ICartService, CartService>();
        }
    }
}
