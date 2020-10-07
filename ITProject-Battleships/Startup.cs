using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Data;
using ITProject_Battleships.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ITProject_Battleships
{
    public class Startup
    {
        public Startup ( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddControllers();

            services.AddDbContext<BattleContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if(env.IsDevelopment ())
            {
                app.UseDeveloperExceptionPage ();
            }

            app.UseCors(builder =>
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());

            app.UseHttpsRedirection ();

            app.UseRouting ();

            app.UseAuthorization ();

            app.UseEndpoints ( endpoints =>
              {
                  endpoints.MapControllers ();
              } );
            //AdminData.Test(app);
            DummyDataManager.Test(app);
        }
    }
}
