using Azure;
using Google.Apis.Http;
using LandPApi.Dto;
using Newtonsoft.Json;
using System.Net;

namespace LandPApi.Middleware
{
    public class CheckAcessMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckAcessMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            //if (httpContext.Request.Path == "/api/Brands")
            //{

            //    Console.WriteLine("CheckAcessMiddleware: Cấm truy cập");
            //    await Task.Run(
            //      async () =>
            //      {
            //string html = "<h1>CAM KHONG DUOC TRUY CAP</h1>";
            ////          httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
            ////          httpContext.Response.Headers.Add("throughCheckAcessMiddleware", new[] { DateTime.Now.ToString() });
            //await httpContext.Response.WriteAsync(html);
            //      }
            //    );

            //}
            //else
            //{

            //    Thiết lập Header cho HttpResponse
            //    httpContext.Response.Headers.Add("throughCheckAcessMiddleware", new[] { DateTime.Now.ToString() });

            //    Console.WriteLine("CheckAcessMiddleware: Cho truy cập");

            //    Chuyển Middleware tiếp theo trong pipeline
            //    await _next(httpContext);

            //}
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }

        }
        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            await context.Response.WriteAsync(JsonConvert.SerializeObject(new Dto.Response
            {
                IsSuccess = false,
                Data = null,
                Message = exception.Message,
                StatusCode = context.Response.StatusCode,
                Timestamp = DateTime.Now
            }));
        }
    }

}


