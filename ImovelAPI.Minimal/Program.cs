using ImovelAPI.Domain.Repositories;
using ImovelAPI.Domain;
namespace ImovelAPI.Minimal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repository = new ImovelRepository();

            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.MapGet("/imovel", () => repository.GetAll());

            app.MapGet("/imovel/{id}", (int id) =>
            {
                if (repository.GetById(id) == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(repository.GetById(id));
            });

            app.MapPost("/imovel", (Imovel imovel) =>
            {
                repository.Add(imovel);
                return new { imovel.Id };
            });


            app.Run();
        }
    }
}
