using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SkillManagement.DataAccess.Infrastructure;
using SkillManagement.DataAccess.Interfaces;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLRepositories;
using SkillManagement.DataAccess.Interfaces.SQLInterfaces.ISQLServices;
using SkillManagement.DataAccess.Repositories;
using SkillManagement.DataAccess.Repositories.SQL_Repositories;
using SkillManagement.DataAccess.Services;
using SkillManagement.DataAccess.Services.SQL_Services;
using SkillManagement.DataAccess.sqlunitOfWork;

namespace SkillAppAdoDapperWebApi
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
            services.AddControllers();
            #region SQL repositories
            services.AddTransient<ISQLEmployeeRepository, SQLEmployeeRepository>();
            services.AddTransient<ISQLSkillRepository, SQLSkillRepository>();
            services.AddTransient<ISQLScoreRepository, SQLScoreRepository>();
            services.AddTransient<ISQLEmployeeSkillRepository, SQLEmployeeSkillRepository>();
            #endregion

            #region SQL services
            services.AddTransient<ISQLEmployeeService, SQLEmployeeService>();
            services.AddTransient<ISQLSkillService, SQLSkillService>();
            services.AddTransient<ISQLScoreService, SQLScoreService>();
            services.AddTransient<ISQLEmployeeSkillService, SQLEmployeeSkillService>();
            #endregion

            services.AddTransient<ISQLunitOfWork, SQLsqlunitOfWork>();

            services.AddTransient<IConnectionFactory, ConnectionFactory>();

            services.AddSingleton<IConfiguration>(Configuration);

        }
    
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
