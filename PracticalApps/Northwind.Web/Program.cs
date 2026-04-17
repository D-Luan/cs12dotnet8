#region Configure the web server host and services.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

#endregion

#region Configure the HTTP pipeline and routes

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapRazorPages();
//app.MapGet("/", () => "Hello World!");

#endregion

app.Run();
WriteLine("This executes after the web server has stopped!");