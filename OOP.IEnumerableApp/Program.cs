
//Define an custom array
var CustomArr = new OOP.IEnumerableApp.Array(1, 2, 3, 4, 5);

//predefined
var arr = new int[] { 1, 2, 3, 4, 5 };
foreach (var item in arr)
{
    Console.WriteLine(item);
}
foreach (var item in CustomArr)
{
    Console.WriteLine(item);
}