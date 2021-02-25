using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExampleDependencyInjection.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        //public byte Photo { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public Grade Grade { get; set; }
    }
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
