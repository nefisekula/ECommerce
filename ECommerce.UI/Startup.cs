using ECommerce.Context;
using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.Models;
using ECommerce.Infrastructure.Repositories;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services;
using ECommerce.Infrastructure.Services.Abstracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace ECommerce.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ApplicationDbContext>(options =>
               options
                .UseSqlServer("Data Source=LAPTOP-QCASAUH8\\MSSQLSERVER2019;Initial Catalog=dev;Integrated Security=True")
                .UseLazyLoadingProxies());

            //services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.Configure<MailInfo>(Configuration.GetSection("MailSettings"));

            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IMailService, MailService>();

            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
