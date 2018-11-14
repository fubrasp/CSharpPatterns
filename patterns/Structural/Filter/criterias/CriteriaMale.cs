using System;
using System.Collections.Generic;
using System.Linq;
using patterns.Structural.Filter.model;
using patterns.Structural.Filter.extensions;

namespace patterns.Structural.Filter.criterias
{
    public class CriteriaMale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            //List<Person> malePersons = (List<Person>)Extensions.Clone<Person>(persons);
            return persons.Where(p => string.Equals(p.Gender, "Male")).ToList();
        }
    }
}
