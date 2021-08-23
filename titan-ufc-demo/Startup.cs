using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.DataAccess;
using titan_ufc_demo.Service;

namespace titan_ufc_demo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<ApplicationDbContext>(x=>
            x.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;Database=Ufc_demo;Trusted_Connection=True;MultipleActiveResultSets=true;Column Encryption Setting=enabled"));
            services.AddControllers();
            services.AddScoped<IUserDataAccess, UserDataAccess>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILocationDataAccess, LocationDataAccess>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IDeviceDataAccess, DeviceDataAccess>();
            services.AddScoped<IDeviceService, DeviceService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapControllers();
            });
        }
    }
}
