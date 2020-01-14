using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            UniversityManager um = new UniversityManager();
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach(int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            um.MaleStudents();
            um.FemaleStudents();

            um.SortStudentsByAge();

            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();
            /*
            Console.WriteLine("Enter the student university Id to search for: ");
            string answer = Console.ReadLine();
            int parsed = Int32.Parse(answer);
            um.FindStudentFromId(parsed);
            */
            Console.ReadKey();

        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Lets add some universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });
            // Lets add some students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Layla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");
            foreach(Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by Age: ");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;
            Console.WriteLine("Students from Beijing Tech: ");
            foreach(Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void FindStudentFromId(int id)
        {
            IEnumerable<Student> searchStudents = from student in students
                                                  join university in universities on
                                                  student.UniversityId equals university.Id
                                                  where student.UniversityId == id select student;
            Console.WriteLine("Students searched by Id: ");
            foreach(Student student in searchStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId
                                equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection:");
            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2}, and Age {3} from University with the Id {4}",
                Name, Id, Gender, Age, UniversityId);
        }
        
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }
}
