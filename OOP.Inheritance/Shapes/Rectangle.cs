using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            
        }
        public Rectangle(int x, int y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawing task...");
        }
        public void Calculate()
        {
            Console.WriteLine("Calculated by rectangle.");
        }
    }
}
