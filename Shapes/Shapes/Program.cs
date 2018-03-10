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
            //Вызывается метод из класса Three
            ThreeDCitle O = new ThreeDCitle();
            O.Draw();
            //Вызываетсяметод из базового класса
            ( (Circle) O).Draw();

            Hexagon Frank = new Hexagon();
            Hexagon hex2 = Frank as Hexagon;
            if (hex2 == null)
            Console.WriteLine("Sorry Frank is not a Hexagon",Frank);
            Console.ReadLine();

        }
    }
}
