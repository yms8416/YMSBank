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
using BilgeAdam.YMSBank.DataAccess.Contracts;
using BilgeAdam.YMSBank.DataAccess.Concretes;

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
            services.AddDbContext<YMSContext>(options => options.UseSqlServer(connstr));
            services.AddScoped<DbContext, YMSContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPersonApi, PersonService>();
            services.AddScoped<ILookupApi, LookupService>();
            services.AddMvc();
            services.AddSwaggerGen(setup =>
            {
                setup.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "1.0.0",
                    Title = "YMS Bank API",
                    Description = "Bizim bankanın kullanım klavuzu",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact
                    {
                        Name = "Can PERK",
                        Email = "can.perk@bilgeadam.com",
                        Url = "https://githubcom/canperk"
                    }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(route => route.MapRoute("Default", "api/{controller}/{action}/{id?}"));
            app.UseSwagger();
            app.UseSwaggerUI(setup => {
                setup.SwaggerEndpoint("/swagger/v1/swagger.json", "YMS Bank API");
            });
        }
    }
}
