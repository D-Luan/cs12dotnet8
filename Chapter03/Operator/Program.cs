//string? authorName = ReadLine();

//int maxLength = authorName?.Length ?? 30;

//authorName ??= "unknown";

bool p = true;
bool q = false;

//WriteLine($"AND   | p     | q     ");
//WriteLine($"p     | {p & p, -5} | {p & q, -5} ");
//WriteLine($"q     | {q & p, -5} | {q & q, -5} ");
//WriteLine();
//WriteLine($"OR    | p     | q     ");
//WriteLine($"p     | {p | p, -5} | {p | q, -5} ");
//WriteLine($"q     | {q | p, -5} | {q | q, -5} ");
//WriteLine();
//WriteLine($"XOR   | p     | q     ");
//WriteLine($"p     | {p ^ p, -5} | {p ^ q, -5} ");
//WriteLine($"q     | {q ^ p, -5} | {q ^ q, -5} ");

WriteLine();

//WriteLine($"p & DoStuff() = {p & DoStuff()}");
//WriteLine($"q & DoStuff() = {q & DoStuff()}");

//WriteLine($"p & DoStuff() = {p && DoStuff()}");
//WriteLine($"q & DoStuff() = {q && DoStuff()}");

//static bool DoStuff()
//{
//    WriteLine("I am doing some stuff.");
//    return true;
//}

//WriteLine();

//int x = 10;
//int y = 6;

//WriteLine($"Expression  | Decimal |   Binary");
//WriteLine($"--------------------------------");
//WriteLine($"x           | {x,7} | {x:B8}");
//WriteLine($"y           | {y,7} | {y:B8}");
//WriteLine($"x & y       | {x & y,7} | {x & y:B8}");
//WriteLine($"x | y       | {x | y,7} | {x | y:B8}");
//WriteLine($"x ^ y       | {x ^ y,7} | {x ^ y:B8}");

//WriteLine($"x << 3      | {x << 3,7} | {x << 3:B8}");

//WriteLine($"x * 8       | {x * 8,7}  | {x * 8:B8}");

//WriteLine($"y >> 1      | {y >> 1,7} | {y >> 1:B8}");

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}