using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMaterial.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<AppState>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
