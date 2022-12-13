using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using infnet_bl6_fdaN_at.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<MyDatabaseContext>(options =>
//        options.UseSqlServer(Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));
builder.Services.AddDbContext<infnet_bl6_fdaN_atContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING") ?? throw new InvalidOperationException("Connection string 'infnet_bl6_fdaN_atContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Pessoas}/{action=Index}/{id?}");

app.Run();
