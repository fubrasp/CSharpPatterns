using System;
using System.Collections.Generic;
using System.Linq;
using patterns.Structural.Filter.model;

namespace patterns.Structural.Filter.criterias
{
    public class OrCriteria : Criteria
    {
        private Criteria _criteria;
        private Criteria _otherCriteria;

        public OrCriteria(Criteria criteria, Criteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = _criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = _otherCriteria.MeetCriteria(persons);
            return firstCriteriaItems.Concat(otherCriteriaItems).ToList();
        }
    }
}
