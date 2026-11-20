using System.Diagnostics;

namespace DemoMVC01.Middlewares
{
    //Rules
    /*
     1] RequestDelegate next [Inject ctor]
     2] Method name InvokeAsync , Invoke [HttpContext context]
     3] Call await next(context) 
     4] Register with app.UseMiddleware<RequestTimingMiddleware>()
     */
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var watch = Stopwatch.StartNew(); //request

            await _next(context);
            //response
            watch.Stop();
            Console.WriteLine($"{context.Request.Path}  ==> {watch.ElapsedMilliseconds} ms");
        }

    }
}
