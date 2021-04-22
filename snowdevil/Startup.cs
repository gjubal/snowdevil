using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using snowdevil.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace snowdevil
{
    public class Startup
    {
        IConfigurationRoot Configuration; 
        public Startup(IWebHostEnvironment env) { 
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json").Build(); 
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<IProductRepository, FakeProductRepository>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); 
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc(options => options.EnableEndpointRouting = false).AddNewtonsoftJson(); 
            services.AddMemoryCache(); services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {

                routes.MapRoute(
                    name: null,
                    template: "faq/",
                    defaults: new { controller = "FAQ", action = "Index"}
                    );

                routes.MapRoute(
                    name: null,
                    template: "about-us/",
                    defaults: new {controller = "Store", action = "Index"}
                    );

                routes.MapRoute(
                    name: null,
                    template: "shipping/",
                    defaults: new { controller = "Store", action = "ShippingIndex" }
                    );

                routes.MapRoute(
                    name: null, 
                    template: "{category}/Page{page:int}", 
                    defaults: new { controller = "Product", action = "List" }
                    ); 

                routes.MapRoute(
                    name: null,
                    template: "Page{page:int}", 
                    defaults: new { controller = "Product", action = "List", page = 1 }
                    ); 
                
                routes.MapRoute(
                    name: null, 
                    template: "{category}", 
                    defaults: new { controller = "Product", action = "List", page = 1 }
                    );
                
                routes.MapRoute(
                    name: null, 
                    template: "", 
                    defaults: new { controller = "Product", action = "List", page = 1 }
                    ); 
                
                routes.MapRoute(
                    name: null, 
                    template: "{controller}/{action}/{id?}"
                    );
                
            });
        }
    }
}
