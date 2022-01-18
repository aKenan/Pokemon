using Adecco.Pokemon.Application.Models.Configuration;
using Adecco.Pokemon.Application.Services;
using Adecco.Pokemon.Infrastructure.AutofacModules;
using Autofac;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Adecco.Pokemon
{
    /// <summary>
    /// Startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configure services.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                var filePath = Path.Combine(AppContext.BaseDirectory, "SimpleSwagger.xml");
                c.IncludeXmlComments(filePath, includeControllerXmlComments: true);
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Kenan Alihodzic: Adecco Test - Pokemon", Version = "v1" });
            });

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddHttpClient<PokemonApiService>();

            services.AddApiVersioning();

            services.Configure<ApiConfigurationModel>(Configuration.GetSection("PokemonApi"));
        }

        /// <summary>
        /// ConfigureContainer is where you can register things directly with Autofac.
        /// This runs after ConfigureServices so the things here will override registrations made in ConfigureServices.
        /// Don't build the container; that gets done for you by the factory.
        /// </summary>
        /// <param name="builder">Builder.</param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            // Register your own things directly with Autofac, like:
            builder.RegisterModule(new ServicesModule());
        }

        /// <summary>
        /// Configure.
        /// </summary>
        /// <param name="app">Application builder.</param>
        /// <param name="env">Host env.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Adecco.Pokemon v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
