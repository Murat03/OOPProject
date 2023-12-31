﻿// See https://aka.ms/new-console-template for more information
using OOP.Inheritance;
using OOP.Inheritance.Shapes;
using OOP.Inheritance.Shapes.Rectangles;
using System.Runtime.Intrinsics.Arm;

var s1 = new Rectangle(10, 20);
Console.WriteLine($"{s1.X}, {s1.Y}");
var s2 = new Triangle(30, 40);
s1.WorkWithDifferentObjects(s2);
s1.WorkWithDifferentObjects(2);

Console.ReadLine();

static void VirtualKeyword()
{
    var s1 = new Rectangle();
    var s2 = new Circle();


    s1.X = 1;
    s1.Y = 2;
    Console.WriteLine($"{s1.X} {s1.Y}");
    s1.Draw();

    s2.X = 3;
    s2.Y = 4;
    Console.WriteLine($"{s2.X} {s2.Y}");
    s2.Draw();

    new Triangle().Draw();
}
static void Polymorphism()
{
    var shapes = new List<Shape>()
    {
        new Rectangle(),
        new Triangle(),
        new Circle(),
        new Square()
    };

    foreach (var shape in shapes)
    {
        shape.Draw();
    }
    new Square().Calculate();
}