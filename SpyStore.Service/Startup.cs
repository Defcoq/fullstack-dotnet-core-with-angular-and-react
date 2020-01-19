using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.IO;
using System.Reflection;
using SpyStore.Dal.EfStructures;
using SpyStore.Dal.Initialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using SpyStore.Dal.Repo;
using SpyStore.Dal.Repo.Interfaces;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.FileProviders;
using Swashbuckle.Swagger;
using Microsoft.OpenApi.Models;
using SpyStore.Service.Filters;

namespace SpyStore.Service
{
    public class Startup
    {
        [Obsolete]
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        public IConfiguration Configuration { get; }

    
        private readonly IWebHostEnvironment _env;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => {
                option.EnableEndpointRouting = false;
                option.Filters.Add(new SpyStoreExceptionFilter(_env));

            }).AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    options.SerializerSettings.Formatting = Formatting.Indented;
                }

              ).SetCompatibilityVersion(CompatibilityVersion.Latest);
            //services.AddMvcCore(config => { 
            //    config.Filters.Add(new SpyStoreExceptionFilter(_env)); 
            //    config.EnableEndpointRouting = false; 
            //    }).AddNewtonsoftJson(options => {
            //    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            //    options.SerializerSettings.Formatting = Formatting.Indented;
            //}).SetCompatibilityVersion(CompatibilityVersion.Latest);
           // services.AddRazorPages();
            // http://docs.asp.net/en/latest/security/cors.html
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                    //.AllowCredentials();
                });
            });

            //NOTE: Did not disable mixed mode running here
            var conn = Configuration.GetConnectionString("SpyStore");
            services.AddDbContextPool<StoreContext>(
            options => options.UseSqlServer(
            Configuration.GetConnectionString("SpyStore")));

            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<ICustomerRepo, CustomerRepo>();
            services.AddScoped<IShoppingCartRepo, ShoppingCartRepo>();
            services.AddScoped<IOrderRepo, OrderRepo>();
            services.AddScoped<IOrderDetailRepo, OrderDetailRepo>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "SpyStore Service",
                    Version = "v1",
                    Description = "Service to support the SpyStore sample eCommerce site",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Jean Pierre Deffo Fotso",
                        Email = string.Empty,
                        Url = new Uri("https://medium.com/@jpdeffo"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Freeware",//Url = "https://en.wikipedia.org/wiki/Freeware"
                        Url = new Uri("http://localhost:23741/LICENSE.txt")
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

                    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                using (var serviceScope =
                                        app
                                        .ApplicationServices
                                        .GetRequiredService<IServiceScopeFactory>()
                                        .CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<StoreContext>();
                    SampleDataInitializer.InitializeData(context);
                }
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SpyStore Service v1");
            });
            app.UseStaticFiles();
            app.UseCors("CorsPolicy"); // has to go before UseMvc

            app.UseMvc();
        }
    }
}
