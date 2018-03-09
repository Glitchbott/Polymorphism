using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    //Менаджарам нужно знать кол-во опцинов на акции
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbofopts)
            :base(fullName,age,empID,currPay,ssn)
        {
            StockOptions=numbofopts;

            ID = empID;
            Name = fullName;
            Age = age;
            Pay = currPay;
           // SocialSecurityNumber = ssn;

        }
        public Manager()
        { }

    }
}
