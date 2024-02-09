using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ImovelAPI.ControllersSwagger.Filters
{
    public class ExceptionCustomFilter : IAsyncExceptionFilter
    {
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            context.Result = new ObjectResult("Error - Try Again Later ")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;

            await Task.CompletedTask;
        }
    }
}
