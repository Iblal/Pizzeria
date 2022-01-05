using Microsoft.Extensions.DependencyInjection;
using PizzaHutServices.Implementations;
using PizzaHutServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHutWebUI.ConfigureDependancies
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            
        }
    }
}
