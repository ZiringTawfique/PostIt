using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataView;
using DataView.Adapters;
using DataView.DataEntities;
using DataView.Interface;
using DataView.Mapping;
using Domain;
using Domain.Interfaces;
using Domain.Model;
using Domain.Ports;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace PostIt.BackEnd
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
            services.AddTransient<IUseCases, UseCases>();
            services.AddTransient<IRepository, MongoRepository>();
            services.AddTransient<IApplicationDataView, ApplicationDataView>();
            services.AddTransient<IToDomainModelMappingFacade, ToDomainModelMappingFacade>();
            services.AddTransient<IToDataEntityMappingFacade , ToDataEntityMappingFacade>();
            services.AddMvc();
            services.AddAutoMapper();
			services.Configure<MongoDBSettings>(options =>
			{
				options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
				options.Database = Configuration.GetSection("MongoConnection:Database").Value;
			});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
