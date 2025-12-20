#region Storing any type of object

object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

#endregion

#region Storing dynamic types.

dynamic something;

something = new[] { 3, 5, 7 };

//something = 12;

//something = "Ahmed";

Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is an {something.GetType()}");

#endregion

#region Inferring the type of a local variable



#endregion


#region Getting and setting the default values for types

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");

#endregion