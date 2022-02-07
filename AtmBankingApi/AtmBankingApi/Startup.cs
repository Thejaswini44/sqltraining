using AtmBanking.BAL.services;
using AtmBanking.DAL.Data;
using AtmBanking.DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmBankingApi
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
            var connectionStr = Configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<AtmDbContext>(options => options.UseSqlServer(connectionStr));
            services.AddControllers();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustomerInfoRepository, CustomerInfoRepository>();
            services.AddTransient<CustomerService, CustomerService>();
           services.AddTransient<CustomerInfoService, CustomerInfoService>();
            services.AddTransient<IAccountDetailsRepository, AccountDetailsRepository>();
            services.AddTransient<AccountDetailsService, AccountDetailsService>();
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<AdminService, AdminService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
