using Microsoft.EntityFrameworkCore;
using PekerStore.Data.Abstract;
using PekerStore.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<StoreDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddScoped<IStoreRepository, EfCoreRepository>();


var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
