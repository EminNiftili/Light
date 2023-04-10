using Light.AppConfig.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Light.AppConfig.Extensions
{
    public static class AppBuilderException
    {
        public static void UseGlobalException(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalErrorHandlingMiddleware>();
        }
    }
}
