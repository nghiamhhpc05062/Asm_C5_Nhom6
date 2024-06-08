using Asm_C5_Nhom6.Data;
using Asm_C5_Nhom6.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asm_C5_Nhom6
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
            //Tạo API
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Asm_C5_Nhom6", Version = "v1" });
            });

            services.AddScoped<IResProduct, ResProduct>();
            services.AddScoped<IResCategory, ResCategory>();
            services.AddScoped<IResMenu, ResMenu>();
            services.AddScoped<IResOrderItem, ResOrderItem>();
            services.AddScoped<IResOrder, ResOrder>();
            services.AddScoped<IResRestaurant, ResRestaurant>();
            services.AddScoped<IResReview, ResReview>();
            services.AddScoped<IResUser, ResUser>();
            services.AddScoped<IResVoter, ResVoter>();

            //Kết Nối
            services.AddDbContext<AppDbcontext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Asm_C5_Nhom6 v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
