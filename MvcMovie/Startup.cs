using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;

using System.Globalization;
using Microsoft.Extensions.Options;

namespace MvcMovie
{
    public class Startup
    {
        private const string defaultCulutreName = "en";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix); ;

            //services.AddDbContext<MvcMovieContext>(options =>
            //  options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            //services.AddPortableObjectLocalization();
            //指定资源文件的位置
            services.AddPortableObjectLocalization(options => options.ResourcesPath = "Localization");
            services.Configure<RequestLocalizationOptions>(options =>
                {
                    var supportedCultures = new List<CultureInfo>
                    {
                     
                        new CultureInfo("en"),
                        new CultureInfo("fr")
                    };

                    options.DefaultRequestCulture = new RequestCulture("en");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                    //要用的语言转换器,来查询字符串，cookie,header
                    options.RequestCultureProviders = new[] { new CookieRequestCultureProvider() };
                    //
                    //options.RequestCultureProviders = new List<IRequestCultureProvider>
                    //{
                    //  new XdoveRequestCultureProvider()//重写的RequestCultureProvider()
                    //};
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

        //    #region Localization
        //    // REMARK: you may refactor this into a separate method as it's better to avoid long methods with regions
        //    var supportedCultures = new[]
        //    {
        //    new CultureInfo(defaultCulutreName),
        //    new CultureInfo("pl-PL")
        //};
        //    var localizationOptions = new RequestLocalizationOptions
        //    {
        //        DefaultRequestCulture = new RequestCulture(defaultCulutreName, defaultCulutreName),
        //        SupportedCultures = supportedCultures,
        //        SupportedUICultures = supportedCultures,
        //        // you can change the list of providers, if you don't want the default behavior
        //        // e.g. the following line enables to pick up culture ONLY from cookies
        //        RequestCultureProviders = new[] { new CookieRequestCultureProvider() }
        //    };
        //    app.UseRequestLocalization(localizationOptions);
        //    #endregion
            app.UseRequestLocalization();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
