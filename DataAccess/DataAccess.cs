using CQRS.Models;

namespace CQRS.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<Student> students = new List<Student>();
        public DataAccess()
        {
            students.Add(new Student { Id = 1, FirstName = "Jhon", LastName = "Doe", Age = 18 });
            students.Add(new Student { Id = 2, FirstName = "Amelia", LastName = "Amy", Age = 16 });
        }

        public Student AddStudent(string firstName, string lastName, double age)
        {
            Student s = new Student();
            s.FirstName = firstName;
            s.LastName = lastName;
            s.Age = age;
            s.Id = students.Count() + 1;
            students.Add(s);
            return s;
            
        }

        public Student GetStudentById(int id)
        {
            var result = students.Where(t => t.Id == id).FirstOrDefault();
            return result;
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
