using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace NetCoreTFCms
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            //services.AddDbContext<MyContext>(x => x.UseMySql("server=localhost;database=yourdb;uid=root;pwd=yourpwd"));
            services.AddDbContext<MyContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<MyContext>(x => x.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            //db first
            //dotnet ef dbcontext scaffold "server=127.0.0.1;port=3306;database=tfcms;user id=root;Ppassword=889988as;" MySql.Data.EntityFrameworkCore
            //dotnet ef dbcontext scaffold "server=211.149.250.24;uid=cc5kk;pwd=889988as;database=cc5kk;" Microsoft.EntityFrameworkCore.SqlServer

            //code first 生成数据库命令
            //dotnet ef migrations add tfcms
            //dotnet ef database update

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "areaRoute",
                   template: "{area:exists}/{controller}/{action}/{id?}",
                   defaults: new { action = "Index", controller = "Home" });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
