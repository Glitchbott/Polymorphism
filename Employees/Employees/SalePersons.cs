using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalePersons : Employee

    {
        public override void GiveBonus(float amount)
        {
            int saleBonus = 0;
            if (SaleNumber >= 0 && SaleNumber <= 100)
                saleBonus = 10;
            else
            {
                if (SaleNumber >= 101 && SaleNumber <= 200)
                saleBonus = 15;
                else
                    saleBonus = 20;
            }
            base.GiveBonus(amount * saleBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Nubmer of Stock Options: {0}", SaleNumber);
        }
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
