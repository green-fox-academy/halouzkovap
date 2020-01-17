using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        public DateTime Birthday { get; private set; } // ctr shift B
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }
        

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
