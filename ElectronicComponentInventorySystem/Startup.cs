using ElectronicComponentInventSyst.BLL;
using ElectronicComponentInventSyst.BLL.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicComponentInventorySystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ElectronicComponentInventoryDbContext>(); //pievienojām datubāzi
            services.AddScoped<DbOperations>(); // pievienojam DB operācijas
            services.AddAutoMapper(options =>
            {
                options.CreateMap<ElectronicComponentInventSyst.Entity.ElectronicComponents, UI.Models.ElectronicComponentsModel>();
                options.CreateMap<UI.Models.ElectronicComponentsModel, ElectronicComponentInventSyst.Entity.ElectronicComponents>();
                options.CreateMap<ElectronicComponentInventSyst.Entity.Category, UI.Models.CategoryModel>();
                options.CreateMap<UI.Models.CategoryModel, ElectronicComponentInventSyst.Entity.Category>();
                options.CreateMap<ElectronicComponentInventSyst.Entity.Footprint, UI.Models.FootprintModel>();
                options.CreateMap<UI.Models.FootprintModel, ElectronicComponentInventSyst.Entity.Footprint>();
                options.CreateMap<ElectronicComponentInventSyst.Entity.StoragaLocation, UI.Models.StorageLocationModel>();
                options.CreateMap<UI.Models.StorageLocationModel, ElectronicComponentInventSyst.Entity.StoragaLocation>();
            });
            services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
