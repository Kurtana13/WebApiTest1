using Microsoft.AspNetCore.Mvc;
using WebApiTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // GET: api/<PeopleController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return PeopleRepository.PeopleList;
        }

        // GET api/<PeopleController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return PeopleRepository.GetPersonById(id);
        }

        // POST api/<PeopleController>
        [HttpPost]
        public void Post(int id, [FromBody] string name)
        {
            PeopleRepository.AddPersonToList(id, name);
        }

        // PUT api/<PeopleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string name)
        {
            PeopleRepository.EditItemInList(id, name);
        }

        // DELETE api/<PeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PeopleRepository.RemovePersonFromTheList(id);
        }
    }
}
