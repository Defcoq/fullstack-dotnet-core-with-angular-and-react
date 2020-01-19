using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpyStore.Mvc.Support;


namespace SpyStore.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }
        //public Startup(IConfiguration configuration, IHostingEnvironment env)
        //{
        //    Configuration = configuration;
        //    _env = env;
        //}


        public IConfiguration Configuration { get; }
        private readonly IWebHostEnvironment _env;
       // private readonly IHostingEnvironment _env;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});


            services.AddMvc(options=> options.EnableEndpointRouting=false).SetCompatibilityVersion(CompatibilityVersion.Latest);
            services.Configure<ServiceSettings>(Configuration.GetSection("ServiceSettings"));
            services.AddHttpClient<SpyStoreServiceWrapper>();

            if (_env.IsDevelopment() || _env.EnvironmentName == "Local")
            {
                services.AddWebOptimizer(false, false);
            }
            else
            {
                services.AddWebOptimizer(options =>
                {
                    options.MinifyCssFiles(); //Minifies all CSS files
                    //options.MinifyJsFiles(); //Minifies all JS files
                    options.MinifyJsFiles("js/site.js");
                    options.AddJavaScriptBundle("js/validations/validationCode.js","js/validations/**/*.js");
                    //options.AddJavaScriptBundle("js/validations/validationCode.js","js/validations/validators.js","js/validations/errorFormatting.js");
            });
        }
        
    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseWebOptimizer();

            app.UseStaticFiles();
           // app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
