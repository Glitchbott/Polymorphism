using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalePersons : Employee

    {
        // Продавцам нужно знать кол-во продаж
        public int SaleNumber { get; set; }
        public SalePersons(string fullName, int age, int empID, float currPay, string ssn, int numboSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            SaleNumber = numboSales;
        }
        public SalePersons()
        { }



    }
        
    
}
