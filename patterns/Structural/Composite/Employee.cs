using System;
using System.Collections.Generic;

namespace patterns.Structural.Composite
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        public List<Employee> Subordinates { get; }

        // constructor
        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            this.salary = sal;
            Subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            Subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            Subordinates.Remove(e);
        }

        public override string ToString() => ($"Employee :[ Name : {name}, dept : {dept}, salary : {salary} ]");
    }
}
