namespace Exercise.Car;

public class Car
{
    public int Wheels { get; set; }
    public bool IsEV { get; set; }
    
    public void Start()
    {
        Console.WriteLine("Starting...");
    }

}
