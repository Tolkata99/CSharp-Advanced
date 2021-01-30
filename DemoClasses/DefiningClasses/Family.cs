using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }


        public void AddPeople(Person member)
        {
            People.Add(member);
        }

        int maxYear = int.MinValue;
        Person person = null;
        public Person GetOldestMember()
        {

            foreach (var currMember in People)
            {
                var currAge = currMember.Age;

                if(maxYear < currAge)
                {
                    maxYear = currAge;
                    person = currMember;
                }
            }

            return person;
        }
    }
}
