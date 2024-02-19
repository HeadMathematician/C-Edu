using Predavanje1.Classes;
using Newtonsoft.Json;

namespace Predavanje1
{
    public class Program
    {
        private List<Student> students = new List<Student>();
        private List<Professor> professors = new List<Professor>();

        public Program()
        {
            students = Student.CreateStudents();
            professors = Professor.CreateProfessors();

            Console.WriteLine("All objects:" );

            foreach(var student in students)
            {
                Console.WriteLine(JsonConvert.SerializeObject(student));
            }
            foreach(var professor in professors)
            {
                Console.WriteLine(JsonConvert.SerializeObject(professor));
            }

            Dictionary<Professor, List<Student>> todaysClass = TodaysClass();

            foreach(var kvp in todaysClass)
            {
                Professor professor = kvp.Key;
                List<Student> students = kvp.Value;

                Console.WriteLine("\nToday's class: ");
                Console.WriteLine("Today's professor is " + professor.Name + " " + professor.LastName + " and he will be teaching " + professor.Subjects.First());
                Console.WriteLine("Today's students are: ");
                for(int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine(i+1 + "." + " " +students[i].Name + " " + students[i].LastName);
                }
            }
        }

        private Professor RandomProfessor()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            if(randomNumber == 1)
            {
                var toReturn = professors.Find(x => x.Id == 1);
                return toReturn;
            }
            else if (randomNumber == 2)
            {
                var toReturn = professors.Find(x => x.Id == 2);
                return toReturn;
            }
            else
            {
                Professor substituteProfessor = new Professor()
                {
                    Id = randomNumber,
                    Name = "Charles",
                    LastName = "Xavier",
                    Subjects = new List<string>() { "Telepathy" }
                };
                return substituteProfessor;
            }
        }

        private Dictionary<Professor, List<Student>> TodaysClass()
        {
            Professor todaysProfessor = RandomProfessor();

            Dictionary<Professor, List<Student>> todaysClass = new Dictionary<Professor, List<Student>>();

            todaysClass.Add(todaysProfessor, students);

            return todaysClass;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
        }

    }
}
