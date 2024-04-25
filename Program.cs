using Microsoft.EntityFrameworkCore;
using Mist452FinalProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Mist452FinalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // 1) fetch information about the connection string 
            var connString = builder.Configuration.GetConnectionString("DefaultConnection");

            // 2) Add the context class to the set of services and define the option to use sql server on that connection string has been fetched in the previous step 
            builder.Services.AddDbContext<ProjectDBContext>(options => options.UseSqlServer(connString));

            builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<ProjectDBContext>().AddDefaultTokenProviders();
            builder.Services.AddRazorPages();
            builder.Services.AddScoped<IEmailSender, EmailSender>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{Area=Player}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
