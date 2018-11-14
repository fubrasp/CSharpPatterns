using System;
using System.Collections.Generic;
using System.Linq;
using patterns.Structural.Filter.model;
using patterns.Structural.Filter.extensions;

namespace patterns.Structural.Filter.criterias
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            //List<Person> femalePersons = (List<Person>)Extensions.Clone<Person>(persons);
            return persons.Where(p => string.Equals(p.Gender, "Female")).ToList();
        }
    }
}
