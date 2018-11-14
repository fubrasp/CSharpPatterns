using System;
using System.Collections.Generic;
using patterns.Structural.Filter.model;
using patterns.Structural.Filter.extensions;


namespace patterns.Structural.Filter.criterias
{
    public class AndCriteria : Criteria
    {
        private Criteria _criteria;
        private Criteria _otherCriteria;

        public AndCriteria(Criteria criteria, Criteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = _criteria.MeetCriteria(persons);
            return _otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}
