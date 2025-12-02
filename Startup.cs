using BookApi.Services;

namespace BookApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<BookService>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app , IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
