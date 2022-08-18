using Microsoft.AspNetCore.Builder;
using WorkerUploadWindowsService.Services;

namespace WorkerUploadWindowsService
{
    public static class Entry
    {
        public static IServiceCollection AddFileDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IFileService, FileService>();
            return services;
        }

        public static WebApplication UseFileMiddlewares(this WebApplication app)
        {
            return app;
        }
    }
}
