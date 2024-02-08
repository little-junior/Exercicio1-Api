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

                if (context.Request.Headers.ContainsKey("UsuarioLogado"))
                {
                    if (context.Request.Headers.TryGetValue("UsuarioLogado", out var usuario))
                    {
                        if (usuario == usuarioEsperado)
                        {
                            await _next.Invoke(context);
                            return;
                        }
                    }
                }

                context.Response.StatusCode = 401;
            } catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync($"Authorization Error: {ex.Message} - Try Again Later");
            }
        }
    }
}
