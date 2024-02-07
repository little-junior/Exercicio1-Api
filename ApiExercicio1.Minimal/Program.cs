using ApiExercicio1.Model.Repositories;
using ApiExercicio1.Model.Entities;
namespace ApiExercicio1.Minimal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repository = new ImovelRepository();

            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.MapGet("/imovel", () => repository.GetAll());

            app.MapGet("/imovel/{id}", (int id) => repository.GetById(id));

            app.MapPost("/imovel", (Imovel imovel) =>
            {
                repository.Add(imovel);
                return new { imovel.Id };
            });



            app.Run();
        }
    }
}
