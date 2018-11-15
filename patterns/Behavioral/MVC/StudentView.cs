using System;
namespace patterns.Behavioral.MVC
{
    public class StudentView
    {
        public void PrintStudentDetails(String studentName, String studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Roll No: {studentRollNo}");
        }
    }
}
