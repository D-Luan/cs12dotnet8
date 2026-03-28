using System.Text.RegularExpressions;

WriteLine("The default regular expression checks for at least one digit.");

Regex inputChecker;
ConsoleKeyInfo cki;

do
{
    Write("Enter a regular expression (or press ENTER to use the default): ");
    string regexUser = ReadLine()!;
    inputChecker = new($@"{regexUser}");

    Write("Enter some input: ");
    string input = ReadLine()!;
    WriteLine($"{input} matches {regexUser}? {inputChecker.IsMatch(input)}");

    WriteLine("Press ESC to end of any key to try again.");
    cki = Console.ReadKey(true);
} while (cki.Key != ConsoleKey.Escape);

WriteLine("End...");