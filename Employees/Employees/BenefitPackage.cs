using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   public  class BenefitPackage
    {
        public enum BenefitPackageLevel
        {
            Standart, Gold, Platinum
        }

        public double ComputerPayDeduction()
        {
            return 125.0;
        }
    }
}
