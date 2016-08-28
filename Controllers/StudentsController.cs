using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new Student[] { 
                new Student(1, "Muhammad"),
                new Student(2, "Sylvia"),
                new Student(3, "Julio")
                };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return new Student(id, "student" + id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Student value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Student value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
