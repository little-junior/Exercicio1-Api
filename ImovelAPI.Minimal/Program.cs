using ImovelAPI.Domain.Repositories;
using ImovelAPI.Domain.DTOs;
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

            app.MapGet("/imovel", () =>
            {
                var imoveis = repository.GetAll();

                if (!imoveis.Any())
                {
                    return Results.NotFound("No objects were found");
                }

                return Results.Ok(imoveis);
            });

            app.MapGet("/imovel/{id}", (int id) =>
            {
                if (repository.GetById(id) == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(repository.GetById(id));
            });

            app.MapPost("/imovel", (ImovelDTO imovelAbstracao) =>
            {
                try {
                    var imovel = new Imovel(imovelAbstracao.Area, imovelAbstracao.Tipo);

                    repository.Add(imovel);
                    return Results.Created($"/imovel/{imovel.Id}", imovel);

                } catch(Exception ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            });

            app.MapDelete("/imovel/{id}", (int id) =>
            {
                var deleted = repository.Delete(id);

                if (deleted)
                {
                    return Results.Ok("Deleted");
                }

                return Results.BadRequest("Id not found");
            });

            app.Run();
        }
    }
}
