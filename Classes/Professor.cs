using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje1.Classes
{
    public  class Professor
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        required
        public List<string> Subjects { get; set; }
        public static List<Professor> CreateProfessors()
        {
            List<Professor> professors = new List<Professor>();

            Professor professor1 = new Professor()
            {
                Id = 1,
                Name = "Gordon",
                LastName = "Ramsay",
                Subjects = new List<string>() { "Cooking", "Hunting", "Fishing" }            
            };

            Professor professor2 = new Professor()
            {
                Id = 2,
                Name = "Joey",
                LastName = "Tribbiani ",
                Subjects = new List<string>() { "Acting", "Eating", "Sleeping" }
            };

            professors.Add(professor1);
            professors.Add(professor2);

            return professors;
        }
    }
}
