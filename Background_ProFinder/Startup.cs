using Background_ProFinder.Data;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Repositories;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Service;
using Background_ProFinder.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace Background_ProFinder
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddDbContext<ThirdGroupContext>();

            services.AddDbContext<ThirdGroupContext>();

            services.AddScoped<LoginService>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    //options.AccessDeniedPath = "Login/AccessDeny";
                    options.LoginPath = new PathString("/Login/Login");
                });
            //注入Repositories
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IQuotationRepository, QuotationRepository>();
            services.AddTransient<IMemberRepository, MemberRepository>();
            services.AddTransient<IBannerRepository, BannerRepository>();
            services.AddTransient<IWorkRepository, WorkRepository>();
            //注入Services
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IHomePageService, HomePageService>();
            

            services.AddTransient<LoginService>();
        }
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();//驗證
            app.UseAuthorization();//授權

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
