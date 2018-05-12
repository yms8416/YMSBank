using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using BilgeAdam.YMSBank.Data.Context;
using Microsoft.EntityFrameworkCore;
using BilgeAdam.YMSBank.Contract;
using BilgeAdam.YMSBank.Business.Concrete;

namespace BilgeAdam.YMSBank.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connstr = Configuration.GetConnectionString("DefaultConnectionString");
            services.AddDbContext<YMSContext>(options =>  options.UseSqlServer(connstr));
            services.AddScoped<IPersonApi, PersonService>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(route => route.MapRoute("Default", "api/{controller}/{action}/{id?}"));
        }
    }
}
