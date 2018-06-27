#r "../src/DayEdge/bin/Debug/netcoreapp2.1/DayEdge.dll"

using DayEdge;

var start = DateTime.Now.StartOfDay();
var end = DateTime.Now.EndOfDay();

Console.WriteLine(start);
Console.WriteLine(end);
