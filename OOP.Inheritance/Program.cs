// See https://aka.ms/new-console-template for more information
using OOP.Inheritance;
using OOP.Inheritance.Shapes;
using OOP.Inheritance.Shapes.Rectangles;

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