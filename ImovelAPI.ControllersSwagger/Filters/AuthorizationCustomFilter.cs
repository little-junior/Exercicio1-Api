using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ImovelAPI.ControllersSwagger.Filters
{
    public class AuthorizationCustomFilter : Attribute, IAuthorizationFilter
    {
        private readonly ILogger<AuthorizationCustomFilter> _logger;
        public AuthorizationCustomFilter(ILogger<AuthorizationCustomFilter> logger)
        {
            _logger = logger;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Headers.ContainsKey("User"))
            {
                _logger.LogInformation("Header not passed");
                context.Result = new UnauthorizedObjectResult(new { Message = "User is needed." });
            }
            if (context.HttpContext.Request.Headers.TryGetValue("User", out var value))
            {
                if (value != "Admin")
                {
                    _logger.LogInformation("User not allowed");
                    context.Result = new UnauthorizedObjectResult(new { Message = "User not allowed." });
                }
            }
        }
    }
}
