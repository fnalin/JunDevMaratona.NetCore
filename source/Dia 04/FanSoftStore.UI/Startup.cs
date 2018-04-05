using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FanSoftStore.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt=> {
                    opt.LoginPath = "/Conta/Login";
                });
            services.AddMvc();
            //services.AddSingleton() //instância única
            services.AddScoped<Data.FanSoftStoreDataContext>(); //escopo por requisição / ciclo de vida da requisição
            //services.AddTransient(); // toda a vez que é necessário ele sobe uma nova instância.
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Data.FanSoftStoreDataContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                Data.DbInitializer.Init(ctx);

            }

            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Recurso não encontrado");
            });
        }
    }
}
