namespace Packt.Shared;

public partial class Person : object
{
    #region Fields: Data or state for this person.

    public string? Name;
    public DateTimeOffset Born;
    // This has been moved to PersonAutoGen.cs as a property.
    //public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    public const string Species = "Homo Sapiens";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    #endregion

    #region Constructors: Called when using new to instantiate a type.

    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero.");
        }

        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    public void Deconstruct(out string? name,
        out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name,
        out DateTimeOffset dob,
        out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    public (string, int) GetNameFruit()
    {
        return ("Banana", 9);
    }

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        z = 100;
        w++;
        y++;
        z++;

        WriteLine($"In the method: w{w}, x={x}, y={y}, z={z}");
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello'!";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

}
