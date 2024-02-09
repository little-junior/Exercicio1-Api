using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace ImovelAPI.ControllersSwagger.Filters
{
    public class ActionValidationCustomFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Select(x => x.Value.Errors.First());
                StringBuilder errorsMessage = new StringBuilder();
                foreach (var item in errors)
                {
                    errorsMessage.Append(item.ErrorMessage + " ");
                };

                context.Result = new BadRequestObjectResult(new
                {
                    Error = true,
                    Message = $"Erro: {errorsMessage} - Try Again"
                });
            }
        }
    }
}
