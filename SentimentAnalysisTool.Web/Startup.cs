using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SentimentAnalysisTool.Services.Implementations;
using SentimentAnalysisTool.Services.Interfaces;
using SentimentAnalysisTool.Web.Helpers.Implementations;
using SentimentAnalysisTool.Web.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SentimentAnalysisTool.Web
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
            services.AddControllersWithViews();

            //Service DI
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IRecordsService, RecordsService>();
            services.AddTransient<IComputingHelper, ComputingHelper>();
            services.AddTransient<ISlangRecordsService, SlangRecordsService>();
            services.AddTransient<ICorpusWordsService, CorpusWordsService>();
            services.AddTransient<IAbbreviationsService, AbbreviationsService>();
            services.AddTransient<ICorpusTypeService, CorpusTypeService>();

            //HttpClient DI
            services.AddHttpClient<AbbreviationsService>(m => m.BaseAddress = new Uri(Configuration.GetValue<string>("BaseUrl")));
            services.AddHttpClient<CommentService>(m => m.BaseAddress = new Uri(Configuration.GetValue<string>("BaseUrl")));
            services.AddHttpClient<SlangRecordsService>(m => m.BaseAddress = new Uri(Configuration.GetValue<string>("BaseUrl")));
            services.AddHttpClient<CorpusWordsService>(m => m.BaseAddress = new Uri(Configuration.GetValue<string>("BaseUrl")));
            services.AddHttpClient<RecordsService>(m => m.BaseAddress = new Uri(Configuration.GetValue<string>("BaseUrl")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
