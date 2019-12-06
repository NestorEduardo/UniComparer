using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UniComparer.Repository;
using UniComparer.Repository.Abstract;

namespace UniComparer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration["Data:UniComparer:ConnectionString"]));
            services.AddTransient<IGradeCategoryRepository, GradeCategoryRepository>();
            services.AddTransient<IGradeRepository, GradeRepository>();
            services.AddTransient<IGradeOfferRepository, GradeOfferRepository>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "Default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
