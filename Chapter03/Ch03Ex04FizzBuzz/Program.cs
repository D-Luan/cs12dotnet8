Console.Write("Enter a number: ");
string? numberText = string.Empty;

int number = 0;
bool isNumberValid = false;

do
{
    numberText = Console.ReadLine();
    isNumberValid = int.TryParse(numberText, out number);

    if (isNumberValid == false)
    {
        Console.WriteLine("Invalid Number! Please enter a valid number.");
    }

} while (isNumberValid == false);

for (int i = 1; i <= number; i++)
{
    if (i % 3 == 0)
    {
        Console.Write("Fizz");
    }

    if (i % 5 == 0)
    {
        Console.Write("Buzz");
    }

    if (i % 3 != 0 && i % 5 != 0)
    {
        Console.Write(i.ToString());
    }

    Console.Write(i != number ? ", " : "");
}

