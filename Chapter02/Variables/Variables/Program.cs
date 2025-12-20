using System.Xml;

//object height = 1.88;
//object name = "Amir";
//Console.WriteLine($"{name} tem {height} metros de altura.");

//int length1 = name.Length;
//int length2 = ((string)name).Length;
//Console.WriteLine($"{name} tem {length2} caracteres.");

//dynamic something;
//something = new[] { 3, 5, 7 };
//something = 12;
//something = "Ahmed";
//Console.WriteLine($"O comprimento de something é {something.Length}");
//Console.WriteLine($"something é um {something.GetType()}");

var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");
