using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Shape()
        {
            
        }
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Base class drawing task...");
        }

        public void WorkWithDifferentObjects(object o)
        {
            if(o is Shape)
            {
                Shape shapeFromParameter = (Shape)o;
                shapeFromParameter.Draw();
            }
            //Shape shapeFromParameter = o as Shape;
            //if (shapeFromParameter is not null)
            //{
            //    shapeFromParameter.Draw();
            //}
        }
    }
}
