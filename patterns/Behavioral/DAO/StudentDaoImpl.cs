using System;
using System.Collections.Generic;

namespace patterns.Behavioral.DAO
{
    public class StudentDaoImpl : IStudentDAO
    {
        //list is working as a database
        public List<Student> students;

        public StudentDaoImpl()
        {
            students = new List<Student>();
            Student student1 = new Student("Robert", 0);
            Student student2 = new Student("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(Student student)
        {
            students.RemoveAt(student.RollNo);
            Console.WriteLine($"Student: Roll No {student.RollNo}, deleted from database");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudent(int rollNo)
        {
            return students[rollNo];
        }

        public void UpdateStudent(Student student)
        {
            students[student.RollNo].Name=student.Name;
            Console.WriteLine($"Student: Roll No {student.RollNo}, updated in the database");
        }
    }
}
