using Microsoft.EntityFrameworkCore;
using YouTubeApp.Data;
using YouTubeApp.Interfaces;
using YouTubeApp.Repositories;

namespace YouTubeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(
                optrions =>
                optrions.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
                );
            builder.Services.AddScoped<IAppointmentRepository,AppointmentRepository>();
            builder.Services.AddScoped<IPatientRepository, PatientRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Appointment}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Patient}/{action=Index}/{id?}");
            
            app.Run();
        }
    }
}
