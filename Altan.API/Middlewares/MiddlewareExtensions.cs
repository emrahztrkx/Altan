using Microsoft.AspNetCore.Builder;

namespace Altan.API.Middlewares
{
    public static  class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler<T>(this IApplicationBuilder app) =>
            app.UseMiddleware<T>();
    }
}