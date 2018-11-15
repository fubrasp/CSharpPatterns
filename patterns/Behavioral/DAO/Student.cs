using System;
namespace patterns.Behavioral.DAO
{
    public class Student
    {
        public String Name { get; set; }
        public int RollNo { get; set; }

       public Student(String name, int rollNo)
        {
            this.Name = name;
            this.RollNo = rollNo;
        }
    }
}
