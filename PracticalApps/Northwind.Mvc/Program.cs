using System.Net.Http.Headers;
using Northwind.EntityModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddNorthwindContext();

builder.Services.AddHttpClient(name: "Northwind.WebApi",
 configureClient: options =>
 {
     options.BaseAddress = new Uri("https://localhost:5151/");
     options.DefaultRequestHeaders.Accept.Add(
     new MediaTypeWithQualityHeaderValue(
     mediaType: "application/json", quality: 1.0));
 });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
