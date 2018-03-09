using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   sealed class PTSalePersons : SalePersons
    {
        public int SaleNumbe { get; set; }
        public PTSalePersons(string fullName, int age, int empID, float currPay, string ssn, int numboSales)
            : base(fullName, age, empID, currPay, ssn, numboSales)
        {
            SaleNumber = numboSales;
        }
        public PTSalePersons()
        { }
    }
}
