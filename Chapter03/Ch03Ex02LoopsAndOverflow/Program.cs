checked
{
    try
    {
        int max = 500;

        for (byte i = 0; i < 500; i++)
        {
            Console.WriteLine(i);
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"{ex.GetType()} says {ex.Message}");
    }
}