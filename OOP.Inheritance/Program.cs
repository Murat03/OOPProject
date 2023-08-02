// See https://aka.ms/new-console-template for more information

using OOP.Inheritance.Shapes;

Console.WriteLine("Hello, World!");

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

Console.ReadLine();