using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // We simply apply out Student-Structure to XML
            string studentsXML = @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>7</Semester>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>4</Semester>
                            </Student>
                        </Students>";
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach(var student in students)
            {
                Console.WriteLine("Student {0} with age of {1} from University of {2} at semester {3}", 
                    student.Name, student.Age, student.University, student.Semester);
            }

            Console.WriteLine("Students Sorted:");

            var studentsSorted = from student in students
                                 orderby student.Age
                                 select student;
            foreach(var student in studentsSorted)
            {
                Console.WriteLine("Student {0} with age of {1} from University of {2} at semester {3}",
                    student.Name, student.Age, student.University, student.Semester);
            }

            Console.Read();
        }
    }
}
