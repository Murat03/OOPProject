// See https://aka.ms/new-console-template for more information

using OOP.Interfaces.ICloneableApp;

var book1 = new Book()
{
    Id = 1,
    Title = "Satranç",
    Price = 20
};
var book2 = book1.Clone() as Book;
book2.Title = "Utopia";

Console.WriteLine(book1.Title);
Console.WriteLine(book2.Title);
