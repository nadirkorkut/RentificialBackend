using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonService _personService;
        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _personService.GetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getpersonbyid")]
        public IActionResult GetPersonById(int id)
        {
            var result = _personService.GetPersonById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public void Add(Person person)
        {
            _personService.Add(person);
        }

        [HttpPut("update")]
        public void Update(Person person)
        {
            _personService.Update(person);
        }

        [HttpDelete("delete")]
        public void Delete(Person person)
        {
            _personService.Delete(person);
        }
    }
}
