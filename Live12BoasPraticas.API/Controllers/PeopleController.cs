using Live12BoasPraticas.API.Application.InputModels;
using Live12BoasPraticas.API.Application.Services;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddPersonInputModel addPersonInputModel)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpPost("{id}/payments")]
        public IActionResult Pay()
        {
            return Ok();
        }
    }
}
