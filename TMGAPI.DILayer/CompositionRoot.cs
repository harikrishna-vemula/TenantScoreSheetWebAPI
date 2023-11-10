using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMGAPI.BusinessLayer.IServices;
using TMGAPI.BusinessLayer.Services;

namespace TMGAPI.DependenciesLayer
{
    public static class CompositionRoot
    {
        public static void ConfiguredRoutings(this IServiceCollection services)
        {
            IConfiguration configuration;
            using (var serviceProvider = services.BuildServiceProvider())
            {
                configuration = serviceProvider.GetService<IConfiguration>();
            }

            /*Implementations and Its Interfaces Registering*/
            services.AddScoped<IUserAccessService, UserAccessService>();
        }
    }
}
