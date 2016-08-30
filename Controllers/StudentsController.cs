using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentService.Controllers
{
    /// <summary>Service for providing operations for <cref>Student</cref></summary>
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        /// <summary> GET list of <cref>Student</cref> </summary>
        [HttpGet]
        [SwaggerOperation("get-students-list")]
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(IEnumerable<Student>))]
        [SwaggerResponse(System.Net.HttpStatusCode.Unauthorized, Type = typeof(Exception))]
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
        [SwaggerOperation("get-student")]
        public Student Get(int id)
        {
            return new Student(id, "student" + id);
        }

        /// <summary>Add a <cref>Student</cref></summary>
        [HttpPost]
        [SwaggerOperation("add-student")]
        public void Post([FromBody]Student value)
        {
        }

        /// <summary> GET details about <cref>Student</cref> </summary>
        /// <param name="id">Student Id</param>
        /// <param name="value">Student details</param>
        [HttpPut("{id}")]
        [SwaggerOperation("update-student")]
        public void Put(int id, [FromBody]Student value)
        {
        }

        /// <summary> Delete details about <cref>Student</cref> </summary>
        /// <param name="id">Student Id</param>
        [HttpDelete("{id}")]
        [SwaggerOperation("remove-student")]
        public void Delete(int id)
        {
        }
    }
}
