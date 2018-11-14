using System;
namespace patterns.Structural.Filter.model
{
    public class Person : ICloneable
    {
        public String Name { get; }
        public String Gender { get; }
        public String MaritalStatus { get; }

        public Person(String name, String gender, String maritalStatus)
        {
            this.Name = name;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
