const int col1 = 4;
const int col2 = 45;
string lines = new string('-', 105);

Console.WriteLine(lines);
Console.WriteLine($"Type    {"Byte(s) of memory", -col1} {"Min", 32} {"Max", col2}");
Console.WriteLine(lines);
Console.WriteLine($"sbyte   {sizeof(sbyte), -col1} {sbyte.MinValue, col2} {sbyte.MaxValue,col2}");
Console.WriteLine($"byte    {sizeof(byte), -col1} {byte.MinValue, col2} {byte.MaxValue,col2}");
Console.WriteLine($"short   {sizeof(short), -col1} {short.MinValue, col2} {short.MaxValue,col2}");
Console.WriteLine($"ushort  {sizeof(ushort), -col1} {ushort.MinValue, col2} {ushort.MaxValue,col2}");
Console.WriteLine($"int     {sizeof(int),-col1} {int.MinValue, col2} {int.MaxValue,col2}");
Console.WriteLine($"uint    {sizeof(uint),-col1} {uint.MinValue, col2} {uint.MaxValue,col2}");
Console.WriteLine($"long    {sizeof(long),-col1} {long.MinValue, col2} {long.MaxValue,col2}");
Console.WriteLine($"ulong   {sizeof(ulong),-col1} {ulong.MinValue, col2} {ulong.MaxValue,col2}");
unsafe
{
	Console.WriteLine($"Int128  {sizeof(Int128),-col1} {Int128.MinValue, col2} {Int128.MaxValue,col2}");
	Console.WriteLine($"UInt128 {sizeof(UInt128),-col1} {UInt128.MinValue, col2} {UInt128.MaxValue,col2}");
    Console.WriteLine($"Half    {sizeof(Half),-col1} {Half.MinValue, col2} {Half.MaxValue,col2}");

}
Console.WriteLine($"float   {sizeof(float),-col1} {float.MinValue, col2} {float.MaxValue,col2}");
Console.WriteLine($"double  {sizeof(double),-col1} {double.MinValue, col2} {double.MaxValue,col2}");
Console.WriteLine($"decimal {sizeof(decimal),-col1} {decimal.MinValue, col2} {decimal.MaxValue,col2}");
