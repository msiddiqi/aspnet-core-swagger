using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService
{
    /// <summary>
    /// Representation of a Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student constructor
        /// <param name="id">Student Id</param>
        /// <param name="name">Student Name</param>
        /// </summary>
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>Student Id</summary>
        public int Id {get; private set;}
        
        ///<summary>Student Name</summary>
        public string Name {get; private set;}
    }
}
