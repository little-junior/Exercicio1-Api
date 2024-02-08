using ImovelAPI.Domain;
using ImovelAPI.Domain.DTOs;
using ImovelAPI.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImovelAPI.ControllersSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ImovelController : ControllerBase
    {
        private readonly IRepository<Imovel, ImovelDTO> _repository;
        public ImovelController(IRepository<Imovel, ImovelDTO> repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var imoveis = _repository.GetAll();

            if (!imoveis.Any())
            {
                return NotFound("No objects were found");
            }

            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var imovel = _repository.GetById(id);

            if (imovel == null)
            {
                return NotFound("Object not found");
            }

            return Ok(imovel);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ImovelDTO imovelAbstracao)
        {
            var imovel = new Imovel(imovelAbstracao.Area, imovelAbstracao.Tipo);

            _repository.Add(imovel);

            return Created($"/api/Imovel/{imovel.Id}", imovel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var deleted = _repository.Delete(id);

            if (deleted)
            {
                return Ok("Deleted");
            }

            return BadRequest("Id not found");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] ImovelDTO imovelAbstracao)
        {
            try
            {
                var updated = _repository.Update(id, imovelAbstracao);

                if (updated)
                {
                    return Ok(_repository.GetById(id));
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
