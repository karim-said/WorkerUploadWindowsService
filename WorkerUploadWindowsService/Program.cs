using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting.WindowsServices;
using WorkerUploadWindowsService;

var options = new WebApplicationOptions
{
    Args = args,
    ContentRootPath = WindowsServiceHelpers.IsWindowsService() ? AppContext.BaseDirectory : default
};

var builder = WebApplication.CreateBuilder(options);

builder.Services.AddControllers();
builder.Services.AddFileDependencies();

builder.Host.UseWindowsService();

var app = builder.Build();

app.Urls.Add("http://localhost:50000");
app.Urls.Add("https://localhost:50001");

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());
await app.RunAsync();
