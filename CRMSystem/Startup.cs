using CRMSystem.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRMSystem.Domain;
using CRMSystem.Domain.Repositories.Interfaces;
using CRMSystem.Domain.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using CRMSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using CRMSystem.Hubs;

namespace CRMSystem
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());

            services.AddTransient<IRequestRepository, EFRequestRepository>();
            services.AddTransient<DataManager>();

            //string mySqlConnectionStr = Config.ConnectionString;
            //services.AddDbContextPool<AppDbContext>
            //    (options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

            //настраиваем identity систему
            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            
            //настраиваем authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "myCompanyAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            services.AddControllersWithViews();
            //.SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
            //.AddSessionStateTempDataProvider();

            //Добавляем SignalR для чатов
            services.AddSignalR();
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

            //подключаем аутентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chat");
            });
        }
    }
}
