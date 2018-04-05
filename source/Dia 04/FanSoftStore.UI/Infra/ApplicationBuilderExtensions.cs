using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace FanSoftStore.UI
{
    public static class ApplicationBuilderExtensions
    {

        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            var path = Path.Combine(root, "node_modules");
            options.FileProvider = new PhysicalFileProvider(path);
            app.UseStaticFiles(options);
            return app;
        }

    }
}
