using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoBase.Persistence.Entity.Context;
using Microsoft.EntityFrameworkCore;
using ProjetoBase.Service.Services.Interfaces;
using ProjetoBase.Service.Services;
using ProjetoBase.Repository.Repositories.Interfaces;
using ProjetoBase.Repository.Repositories;

namespace ProjetoBase
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
            services.AddMvc();

            //recuperando str connection DbContext
            //string connectionString = Configuration.GetConnectionString("ProjetoBaseCoreDbContext");
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjetoBaseCore;Integrated Security=True;user id=Teste; password=Teste;";
            services.AddDbContext<ProjetoBaseCoreDbContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(connectionString);
            });

            services.AddTransient<IPessoaService, PessoaService>();

            services.AddTransient<IPessoaRepository, PessoaRepository>();

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
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
