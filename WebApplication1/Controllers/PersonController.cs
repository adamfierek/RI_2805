using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly EfDataContext dataContext;

        public PersonController(EfDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var people = dataContext.People.ToList();
            return Ok(people);
        }

        [HttpGet("get/{id:int}")]
        public IActionResult Get(int id)
        {
            var person = dataContext.People.FirstOrDefault(p => p.Id == id);
            if (person is null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Person person)
        {
            dataContext.People.Add(person);
            dataContext.SaveChanges();
            return Ok();
        }

        //[HttpGet("fish/{id:int}")]
        //public IActionResult GetPhoto(int id)
        //{

        //}
    }
}
