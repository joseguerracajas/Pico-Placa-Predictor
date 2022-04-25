using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pico_Placa_Predictor.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Pico_Placa_PredictorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pico_Placa_PredictorContext") ?? throw new InvalidOperationException("Connection string 'Pico_Placa_PredictorContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddControllers(options => options.UseDateOnlyTimeOnlyStringConverters())
    .AddJsonOptions(options => options.UseDateOnlyTimeOnlyStringConverters());
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
    pattern: "{controller=Predictor}/{action=Index}/{id?}");

app.Run();
