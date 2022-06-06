using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }
        List<Person> family;
        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            Members.Add(member);
        } 
        public Person GetOldestMember()
        {
            int maxAge = Members.Max(member => member.Age);
            return this.Members.First(member => member.Age == maxAge);
        }
    }
}
