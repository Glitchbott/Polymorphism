using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with System.Object***\n");
            Person p1 = new Person();
            // У наследованные члены System
            Console.WriteLine("ToString: {0}",p1.ToString());
            Console.WriteLine("Hash code: {0}",p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());
            //Создать другую сылку на p1
            Person p2 = p1;
            object o = p2;

            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
                Console.ReadLine();
            }

        }
    }
}
