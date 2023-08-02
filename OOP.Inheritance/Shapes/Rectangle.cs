﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.Shapes
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawing task...");
        }
    }
}
