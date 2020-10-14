using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Data;
using ITProject_Battleships.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text;
using ITProject_Battleships.Data.Repositories;


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

            services.AddAuthentication ( JwtBearerDefaults.AuthenticationScheme )
                .AddJwtBearer ( options =>
                  {
                      options.TokenValidationParameters = new TokenValidationParameters
                      {
                          ValidateIssuer = true,
                          ValidateAudience = true,
                          ValidateLifetime = true,
                          ValidateIssuerSigningKey = true,
                          ValidIssuer = Configuration["Jwt:Issuer"],
                          ValidAudience = Configuration["Jwt:Issuer"],
                          IssuerSigningKey = new SymmetricSecurityKey(
                              Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))

                      };
                  } );
                

            services.AddDbContext<BattleContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));

            services.AddScoped<AdminRepository> ();

            services.AddScoped<PlayerRepository>();

            services.AddScoped<BattleFieldRepository>();


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

            app.UseAuthentication ();

            app.UseAuthorization ();

            app.UseEndpoints ( endpoints =>
              {
                  endpoints.MapControllers ();
              } );


            AdminData.Test(app);
            DummyData.Test(app); //remove when not testing
        }
    }
}
