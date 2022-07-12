// See https://aka.ms/new-console-template for more information
using ConsoleApp4;

FibonacciSeries series  = new FibonacciSeries();
var s = series.Get(8);
foreach (var i in s)
{
    Console.WriteLine(i);
}

