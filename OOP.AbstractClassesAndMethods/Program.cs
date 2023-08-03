// See https://aka.ms/new-console-template for more information
using OOP.AbstractClassesAndMethods;

Console.WriteLine("Hello, World!");

var arr = new[] { 1, 2, 3, 8, 7, 6 };
var minHeap = new MinHeap();
var maxHeap = new MaxHeap();

foreach (var item in arr)
{
    minHeap.Insert(item);
    maxHeap.Insert(item);
}
Console.WriteLine(minHeap.Extract());
Console.WriteLine(maxHeap.Extract());
Console.ReadLine();