﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.Shapes.Rectangles
{
    public class Square : Rectangle
    {
        new public void Calculate()
        {
            Console.WriteLine("Calculated by square.");
        }
    }
}
