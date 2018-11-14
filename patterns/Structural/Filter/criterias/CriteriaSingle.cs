using System;
using System.Collections.Generic;
using patterns.Structural.Filter.criterias;
using patterns.Structural.Filter.model;
using patterns.Structural.Filter.extensions;
using System.Linq;

namespace patterns.Filter.criterias
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            //List<Person> singlePersons = (List<Person>)Extensions.Clone<Person>(persons);
            return persons.Where(p => string.Equals(p.Gender, "Single")).ToList();
        }
    }
}
