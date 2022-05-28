using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService personService;

        public PersonController(PersonService personService)
        {
            this.personService = personService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(personService.GetAll());
        }

        [HttpGet("get/{id:int}")]
        public IActionResult Get(int id)
        {
            var person = personService.GetAll().FirstOrDefault(p => p.Id == id);
            if (person is null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Person person)
        {
            personService.Add(person);
            return Ok();
        }
    }
}
