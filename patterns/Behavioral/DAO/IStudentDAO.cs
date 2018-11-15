using System;
using System.Collections.Generic;

namespace patterns.Behavioral.DAO
{
    public interface IStudentDAO
    {
        List<Student> GetAllStudents();
        Student GetStudent(int rollNo);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}
