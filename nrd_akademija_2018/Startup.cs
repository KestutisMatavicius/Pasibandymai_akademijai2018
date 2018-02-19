using AutoMapper;
using EF;
using EF.Automapper;
using EF.repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;

namespace nrd_akademija_2018
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
            services.AddDbContext<NrdAkademijaDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("AkademijaDatabase")));
            services.AddScoped<IBlogRepository, BlogRepository>();


            services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));


            services.AddMvc();

            var serviceProvider = services.BuildServiceProvider();
            //configure nlog
            var loggerFactory = serviceProvider.GetService<Microsoft.Extensions.Logging.ILoggerFactory>();
            loggerFactory.AddNLog();
            loggerFactory.ConfigureNLog("nlog.config");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            loggerFactory.AddNLog();
            app.AddNLogWeb();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //}

            app.UseMvc();
        }
    }
}
