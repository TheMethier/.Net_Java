// See https://aka.ms/new-console-template for more information
using Lab1;

Console.WriteLine("Hello, World!");
Problem problem = new Problem(1, 10);
List<Item> items = new List<Item>() { 
    new Item(0,4,7),
    new Item(1,22,14),
    new Item(2,13, 19),
    new Item(3,27, 10),
    new Item(4,18,3),
    new Item(5,7,1),
    new Item(6,28,9),
    new Item(7,19,20),
    new Item(8,18,8),
    new Item(9,20,20),
};
Problem problem1 = new Problem(items);
Console.WriteLine(problem1.ToString());
Result result=problem1.Solve(50);
Console.WriteLine(result.ToString());
