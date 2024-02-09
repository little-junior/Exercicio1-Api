using ImovelAPI.Domain;
using ImovelAPI.Domain.Repositories;
using ImovelAPI.Domain.DTOs;
using ImovelAPI.ControllersSwagger.Filters;
using ImovelAPI.ControllersSwagger.Middlewares;
using Microsoft.AspNetCore.Mvc;

namespace ImovelAPI.ControllersSwagger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(options =>
            {
                options.Filters.Add<ExceptionCustomFilter>();
                options.Filters.Add<ActionValidationCustomFilter>();
            });

            builder.Services.AddSingleton<IRepository<Imovel, ImovelDTO>, ImovelRepository>();

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            //app.UseMiddleware<AutorizacaoMiddleware>();
            //app.UseMiddleware<ErrorHandlerMiddleware>();

            app.MapControllers();

            app.Run();
        }
    }
}

