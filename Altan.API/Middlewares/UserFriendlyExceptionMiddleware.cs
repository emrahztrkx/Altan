using System;
using System.Net;
using System.Threading.Tasks;
using Altan.Core.Shared.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Altan.API.Middlewares
{
    public class UserFriendlyExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<UserFriendlyExceptionMiddleware> _logger;

        public UserFriendlyExceptionMiddleware(RequestDelegate next, ILogger<UserFriendlyExceptionMiddleware> logger)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (UserFriendlyException e)
            {
                //log
                _logger.LogError($"Exception details: {e}");

                //response with message & code
                await HandleExceptionAsync(context, e);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, UserFriendlyException e)
        {
            var statusCode = (int) HttpStatusCode.InternalServerError;
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            var errorModel = new Response(e.Code, e.Message, false);

            return context.Response.WriteAsync(JsonConvert.SerializeObject(errorModel));
        }
    }
}