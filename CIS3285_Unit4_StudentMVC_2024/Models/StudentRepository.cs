namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class StudentRepository
    {
        private List<StudentModel> myStudents;

        public StudentRepository()
        {
            myStudents = new List<StudentModel>
            {
                new StudentModel { Id = 1, Name = "John Doe", Credits = 30 },
                new StudentModel { Id = 2, Name = "Jane Smith", Credits = 45 },
                new StudentModel { Id = 3, Name = "Sam Brown", Credits = 60 }
            };
        }

        public List<StudentModel> getAllStudent()
        {
            return myStudents;
        }

        public StudentModel getStudentById(int id)
        {
            return myStudents.Find(s => s.Id == id);
        }

        public StudentModel getOneStudent(int index)
        {
            return (myStudents[index]);
        }
    }
}
