using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using MVC6_Example.Filters;
using MVC6_Example.Services;
using MVC6_Example.Services.Implementations;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MVC6_Example
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.InputFormatters.Clear();

                var jsonOutputFormatter = new JsonOutputFormatter
                {
                    SerializerSettings =
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver(),
                        DefaultValueHandling = DefaultValueHandling.Ignore,
                        DateFormatHandling = DateFormatHandling.IsoDateFormat
                    }
                };

                options.OutputFormatters.RemoveType<JsonOutputFormatter>();
                options.OutputFormatters.Insert(0, jsonOutputFormatter);
            });

            services.AddScoped<IExampleService, ExampleService>();
            services.AddScoped<ExampleFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
            app.UseDeveloperExceptionPage();

            //Convention based routing
            app.UseMvc(routes => { routes.MapRoute("default", "{controller=MvcExample}/{action=Index}/{id?}"); });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
