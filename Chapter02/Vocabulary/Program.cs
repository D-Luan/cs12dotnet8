using System.Reflection;

//System.Data.DataSet ds = new();
//HttpClient client = new();

//#error version
//WriteLine($"Computer named {Env.MachineName} says \"No\".");


//Assembly? myApp = Assembly.GetEntryAssembly();

//if (myApp is null) return;

//foreach (AssemblyName name in myApp.GetReferencedAssemblies())
//{
//    Assembly a = Assembly.Load(name);

//    int methodCount = 0;

//    foreach (TypeInfo t in a.DefinedTypes)
//    {
//        methodCount += t.GetMethods().Length;
//    }

//    WriteLine("{0:N0} types with {1:N0} methods in {2}",
//        arg0: a.DefinedTypes.Count(),
//        arg1: methodCount,
//        arg2: name.Name);
//}

//double heightInMetres = 1.88;
//Console.WriteLine($"Name variable {nameof(heightInMetres)}, variable value: {heightInMetres}");

string horizontalLine = new('-', count: 74);
Console.WriteLine(horizontalLine);

string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);
