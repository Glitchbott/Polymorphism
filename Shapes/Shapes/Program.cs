using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Polimorphism****\n");
            //Массив совместимых с Shape объектов.
            Shape[] myshapes = { new Hexagon(), new Circle(), new Hexagon("Nick"), new Circle("Linda") };
            // цикл по объектам
            foreach(Shape s in myshapes)
            {
                s.Draw();

            }
            Console.ReadLine();

        }
    }
}
