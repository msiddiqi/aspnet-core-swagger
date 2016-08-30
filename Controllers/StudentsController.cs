using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentService.Controllers
{
    /// <summary>Service for providing operations for <cref>Student</cref></summary>
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        /// <summary> GET list of <cref>Student</cref> </summary>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return new Student[] { 
                new Student(1, "Muhammad"),
                new Student(2, "Sylvia"),
                new Student(3, "Julio")
                };
        }

        /// <summary> GET details about <cref>Student</cref> </summary>
        /// <param name="id">Student Id</param>
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return new Student(id, "student" + id);
        }

        /// <summary>Add a <cref>Student</cref></summary>
        [HttpPost]
        public void Post([FromBody]Student value)
        {
        }

        /// <summary> GET details about <cref>Student</cref> </summary>
        /// <param name="id">Student Id</param>
        /// <param name="value">Student details</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Student value)
        {
        }

        /// <summary> Delete details about <cref>Student</cref> </summary>
        /// <param name="id">Student Id</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
