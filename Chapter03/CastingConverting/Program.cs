using System;

double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 } ,
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 }
};

foreach (double n in doubles)
{
    Console.WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0,
            mode: MidpointRounding.AwayFromZero));
}

byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");

for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X2}");
}
WriteLine();

string encoded = Convert.ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");