using System;
using System.Collections.Generic;
using patterns.Structural.Filter.model;

namespace patterns.Structural.Filter.criterias
{
    public interface Criteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}
