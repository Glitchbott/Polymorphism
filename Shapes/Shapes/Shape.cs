using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   abstract class Shape
    {
        
        public Shape (string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }
        //Все дочерние классы определяют свою визуализацию
        public abstract void Draw();
        

    }
}
