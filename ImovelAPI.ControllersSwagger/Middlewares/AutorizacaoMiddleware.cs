namespace ImovelAPI.ControllersSwagger.Middlewares
{
    public class AutorizacaoMiddleware
    {
        private readonly RequestDelegate _next;

        public AutorizacaoMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                const string usuarioEsperado = "Admin";

                if (!context.Request.Headers.ContainsKey("UsuarioLogado"))
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsJsonAsync("The header 'UsuarioLogado' is required");
                    return;
                }

                if (!context.Request.Headers.TryGetValue("UsuarioLogado", out var usuario))
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsJsonAsync("The value of 'UsuarioLogado' couldn't be read");
                    return;
                }

                if (String.IsNullOrEmpty(usuario))
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsJsonAsync("The value of 'UsuarioLogado' can't be null");
                    return;
                }

                if (usuario != usuarioEsperado)
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsJsonAsync("Access denied");
                    return;
                }

                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync($"Authorization Error: {ex.Message} - Try Again Later");
            }
        }
    }
}
