using Live12BoasPraticas.API.Application.InputModels;
using Live12BoasPraticas.API.Application.Services;
using Live12BoasPraticas.API.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Live12BoasPraticas.API.Controllers
{
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _peopleService;
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }  

        // NÃO FAZER ISSO api/people/getAllPeople 
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // NÃO FAZER ISSO api/people/1/invitations/20/approve
        // NÃO É CRIME USAR VERBOS, MAS EVITAR AO MÁXIMO
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // NÃO FAZER ISSO api/company/1/people/add HTTP POST
        // api/company/1/people HTTP POST
        [HttpPost]
        public IActionResult Post([FromBody] AddPersonInputModel addPersonInputModel)
        {
            // Existem erros de validação? 
            // return BadRequest(); DE DETALHES DO ERRO PELO AMOR DE DEUS

            // Existe algum recurso recurso interno dele que não é encontrado
            // return NotFound("Company wasn't found");

            // return Ok(); OK O QUE? QUAL O ID? PARA ONDE EU ABRO DETALHES DESSE OBJETO CRIADO?

            // Location: localhost:5001/api/people/3

            return CreatedAtAction(nameof(GetById), new { id = 3 }, new { Id = 1, Name = "Ola" });
        }

        // api/people/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdatePersonInputModel updatePersonInputModel)
        {
            // HTTP PUT "TEORICAMENTE" ELE PODERIA CADASTRAR UM OBJETO,Se quiser, cadastra e retorna CreatedAtAction
            // Nao xiste o recurso? return NotFound(); 
            // Objeto está inválida? return BadRequest();

            // Objeto está TOP? 

            return NoContent();
        }

        [HttpPost("{id}/payments")]
        public IActionResult Pay()
        {
            // processar de maneira fire-and-forget / asíncrona

            return Accepted();
        }
    }
}
