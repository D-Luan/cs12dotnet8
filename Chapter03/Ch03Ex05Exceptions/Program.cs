Console.Write("Enter a number between 0 and 255: ");
string n1 = Console.ReadLine()!;

Console.Write("Enter another number between 0 and 255: ");
string n2 = Console.ReadLine()!;

try
{
    byte a = byte.Parse(n1);
    byte b = byte.Parse(n2);

    int answer = a / b;

    Console.WriteLine($"{a} divided by {b} is {answer}");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}