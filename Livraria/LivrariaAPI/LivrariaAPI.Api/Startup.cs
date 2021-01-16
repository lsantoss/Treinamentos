using LivrariaAPI.Domain.Handlers;
using LivrariaAPI.Domain.Interfaces.Repositories;
using LivrariaAPI.Infra;
using LivrariaAPI.Infra.DataContexts;
using LivrariaAPI.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace LivrariaAPI.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            #region [+] AppSettings

            services.Configure<SettingsInfra>(options => Configuration.GetSection("SettingsInfra").Bind(options));

            #endregion

            #region [+] DataContexts

            services.AddScoped<DataContext>();

            #endregion

            #region [+] Handlers

            services.AddTransient<LivroHandler>();

            #endregion

            #region [+] Repositories

            services.AddTransient<ILivroRepository, LivroRepository>();

            #endregion

            #region [+] Swagger

            services.AddSwaggerGen(c =>
            {
                //c.DescribeAllEnumsAsStrings();
                c.DescribeAllParametersInCamelCase();
                c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\Swagger.xml");                
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "LivrariaAPI",
                    Description = "Projeto responsável por gerenciar uma livraria",
                    Contact = new OpenApiContact
                    {
                        Name = "Lucas Santos",
                        Email = "l_santos@hotmail.com.br",
                        Url = new Uri("https://github.com/lsantoss"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Licença MIT",
                        Url = new Uri("https://github.com/lsantoss/Treinamentos/blob/main/LICENSE"),
                    }
                });
            });

            #endregion

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "LivrariaAPI");
            });

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