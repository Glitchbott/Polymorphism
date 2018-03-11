using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirsName = fName;
            LastName = lName;
            Age = personAge;

        }
        public Person() {}
        public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirsName, LastName, Age);
            return myState;
        }
    }
}
