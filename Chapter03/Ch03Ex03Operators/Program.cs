int x = 3;
int y = 2 + ++x;

Console.WriteLine($"x: {x}, y: {y}");
Console.WriteLine();

x = 3 << 2;
y = 10 >> 1;

Console.WriteLine($"bits x: {x:B8}, x: {x}");
Console.WriteLine($"bits y: {y:B8}, x: {y}");
Console.WriteLine();

x = 10 & 8;
y = 10 | 7;

Console.WriteLine($"x: {x}");
Console.WriteLine($"y: {y}");