using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje1.Classes
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }

        public static List<Student> CreateStudents()
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                Id = 1,
                Name = "John",
                LastName = "Wick",
                Age = 22
            };

            Student student2 = new Student()
            {
                Id = 2,
                Name = "Marco",
                LastName = "Polo",
                Age = 25,
            };

            students.Add(student1);
            students.Add(student2);

            return students;
        }
    }
}
