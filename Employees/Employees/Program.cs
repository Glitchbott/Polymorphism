using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Inheritance****\n");
            SalePersons Fred = new SalePersons();
            Fred.Name = "Fred";
            Fred.Age = 31;
            Fred.SaleNumber = 50;

            Console.WriteLine("My name is {0}", Fred.Name);
            Console.WriteLine("My age is {0}", Fred.Age);
            Console.WriteLine("I sale {0}", Fred.SaleNumber);
            Console.WriteLine();
            // (string fullName, int age, int empID, float currPay,string ssn, int numbofopts);
            Manager chuck = new Manager("Chuck", 50, 90, 10000,"", 9000);
            chuck.GiveBonus(300);
            chuck.DisplayStats();
            Console.WriteLine();

            SalePersons Fran = new SalePersons("Fran", 43, 93, 3000, "", 31);
            Fran.GiveBonus(300);
            Fran.DisplayStats();


            double cost = chuck.GetBenefitCost();
            Employees.BenefitPackage.BenefitPackageLevel myBenefitPackageLevel = 
            Employees.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.ReadLine();
           
        

        }
    }
}
