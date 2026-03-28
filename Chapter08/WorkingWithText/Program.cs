using System.Globalization;

string fullName = "Alan Shore";

int indexOfTheSpace = fullName.IndexOf(' ');

string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace);

string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);

WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

string text1 = "Mark";
string text2 = "MARK";

WriteLine($"text1: {text1}, text2: {text2}");

WriteLine("Compare: {0}.", string.Compare(text1, text2));

WriteLine("Compare (ignoreCase): {0}.", string.Compare(text1, text2, ignoreCase: true));

WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
    string.Compare(text1, text2,
    StringComparison.InvariantCultureIgnoreCase));

string fruit = "Apples";
decimal price = 0.39M;
DateTime when = DateTime.Today;

WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
    arg0: fruit, arg1: price, arg2: when));