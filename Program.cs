using Daewoo_Web_Application.Models;
using Daewoo_Web_Application.Models.Interfaces;
using Daewoo_Web_Application.Models.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserRepo, UserRepository>(); //Adding Dependancy Injection
builder.Services.AddScoped<IBookingSchedulesRepo, BookingSchedulesRepository>(); //Adding Dependancy Injection
builder.Services.AddScoped<ITerminalRepo, TerminalRepository>();//Adding Dependancy Injection


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Home}/{id?}");

app.Run();
