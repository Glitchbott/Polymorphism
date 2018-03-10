using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program1
    {
        static void CastingExample()
        {
            // Manage является Syste,object поэтому можно сохранять ссылку на manager в переменной objectЫ 
            object Fran = new Manager("Fran Zappa", 9, 900, 3000, "932-32-3232", 5);
            //Manager является employee
            Employee moonUnit = new Manager("MoonUnit", 2, 3001, 2000, "952-5462-35632", 1);
            // PTSaleperson является Salesperson
            SalePersons jill = new PTSalePersons("JILL", 435, 23, 56, "43-76-23", 6);
            GivePromotion(moonUnit);
            GivePromotion(jill);
            void GivePromotion(Employee emp)
            {
                //Повысить зарплату
                // Представить место на парковке
                Console.WriteLine("{0} was promoted", emp.Name);
            }
           
        }
    }
}
