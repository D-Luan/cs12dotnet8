int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8400;

Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");

Console.WriteLine($"int usa {sizeof(int)}");
Console.WriteLine($"double usa {sizeof(double)}");
Console.WriteLine($"decimal usa {sizeof(decimal)}");

Console.WriteLine("Usando double:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} é igual a 0.3");
}
else
{
    Console.WriteLine($"{a} + {b} NÃO é igual a 0.3");
}

Console.WriteLine("Usando decimals:");
decimal c = 0.1M;
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} é igual a {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} NÃO é igual a {0.3M}");
}
