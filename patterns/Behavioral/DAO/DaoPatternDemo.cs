using System;
namespace patterns.Behavioral.DAO
{
    public class DaoPatternDemo
    {
        public static void Start()
        {
            IStudentDAO studentDao = new StudentDaoImpl();
            // Print all students
            studentDao.GetAllStudents().ForEach(s => Console.WriteLine($"Student: [RollNo : {s.RollNo}, Name : {s.Name} ]"));

            //update student
            Student student = studentDao.GetAllStudents()[0];
            student.Name="Michael";
            studentDao.UpdateStudent(student);

            //get the student
            studentDao.GetStudent(0);
            Console.WriteLine($"Student: [RollNo : {student.RollNo}, Name : {student.Name} ]");
        }
    }
}
