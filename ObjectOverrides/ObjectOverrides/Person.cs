﻿using System;
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
        public string SSN { get; set; }

        public override int GetHashCode()
        {
            //Вернуть хеш-код на основе уникальных строковых данных
            return this.ToString().GetHashCode();
        }
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
        public override bool Equals(object obj)
        {
            if(obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if(temp.FirsName == this.FirsName && 
                   temp.LastName == this.LastName && 
                   temp.Age == this.Age)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
           /* static*/ void StaticMembersOfObject()
            {
                Person p3 = new Person("Sally", "Jones", 4);
                Person p4 = new Person("Sally", "Jones", 4);
                Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
                Console.WriteLine("P3 and P4 are pointing to same object: {0}", object.ReferenceEquals(p3, p4));

            }

        }
    }
}
