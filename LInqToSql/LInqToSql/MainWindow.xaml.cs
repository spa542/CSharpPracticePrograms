using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LInqToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.RosiakDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfToni();
            //GetLecturesFromToni();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransgenders();
            //GetAllLecturesTaughtAtBJT();
            //UpdateToni();
            //DeleteJames();
            
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University bjt = new University();
            bjt.Name = "Beijing Tech";
            dataContext.Universities.InsertOnSubmit(bjt);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            // Same as:
            // from university in dataContext.University where university == "Yale" select university
            // Difference is that we are returning a single object! Not and IEnumerable collection 
            // like in past videos
            University bjt = dataContext.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Toni", Gender = "Male", University = yale });
            students.Add(new Student { Name = "Leyla", Gender = "Female", University = bjt });
            students.Add(new Student { Name = "James", Gender = "Trans-gender", University = bjt });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            Student Leyla = dataContext.Students.First(st => st.Name.Equals("Leyla"));
            Student James = dataContext.Students.First(st => st.Name.Equals("James"));

            Lecture Math = dataContext.Lectures.First(le => le.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(le => le.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Leyla, Lecture = History });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = History });
            /*
            StudentLecture slToni = new StudentLecture();
            slToni.Student = Toni;
            slToni.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slToni);
            */
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            University TonisUniversity = Toni.University;
            List<University> universities = new List<University>();
            universities.Add(TonisUniversity);
            MainDataGrid.ItemsSource = universities;
        }
        
        public void GetLecturesFromToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            var tonisLectures = from sl in Toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;
            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgenderUniversities = from student in dataContext.Students
                                          join university in dataContext.Universities
                                          on student.University equals university
                                          where student.Gender == "Trans-gender"
                                          select university;
            MainDataGrid.ItemsSource = transgenderUniversities;
        }

        public void GetAllLecturesTaughtAtBJT()
        {
            var allLecturesAtBJT = from sl in dataContext.StudentLectures
                                   join student in dataContext.Students on sl.StudentId
                                   equals student.Id
                                   where student.University.Name == "Beijing Tech"
                                   select sl.Lecture;
            MainDataGrid.ItemsSource = allLecturesAtBJT;
        }

        public void UpdateToni()
        {
            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name.Equals("Toni"));

            Toni.Name = "Antonia";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteJames()
        {
            Student James = dataContext.Students.FirstOrDefault(st => st.Name.Equals("James"));
            dataContext.Students.DeleteOnSubmit(James);
            dataContext.SubmitChanges();

            // If run into Error! Must reset the connection
            // tring connectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.RosiakDBConnectionString"].ConnectionString;
            // db = new LinqToSqlDataClassesDataContext(connectionString);
            // Then use db.Students and not dataContext
            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
