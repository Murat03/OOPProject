// See https://aka.ms/new-console-template for more information

using OOP.Interfaces.GetEnumerateApp;

var collection = new List<Product>()
{
    new Product{ ProductId = 1, ProductName = "PC", Price = 15000},
    new Product{ ProductId = 2, ProductName = "Buz Dolabı", Price = 12500},
    new Product{ ProductId = 3, ProductName = "Kahve Makinası", Price = 3000},
    new Product{ ProductId = 4, ProductName = "Çamaşır Makinası", Price = 8000},
    new Product{ ProductId = 5, ProductName = "Air Fryer", Price = 3000}
};
foreach (var product in collection)
{
    Console.WriteLine($"{product.ProductId} {product.ProductName} {product.Price}");
}
Console.WriteLine(new string('-', 25));

IEnumerator<Product> enumerator = collection.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine($"{enumerator.Current.ProductId}" +
        $" {enumerator.Current.ProductName}" +
        $" {enumerator.Current.Price}");
}
Console.ReadKey();