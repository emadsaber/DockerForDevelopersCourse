using Microsoft.EntityFrameworkCore;
using MyStore.Data;

namespace MyStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connStr = builder.Configuration.GetConnectionString("Default");
            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<IMyStoreDbContext, MyStoreDbContext>(opt => opt.UseSqlServer(connStr));
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<MyStoreDbContext>();
                context.Database.Migrate();
            }


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
