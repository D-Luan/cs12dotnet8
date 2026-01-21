namespace Packt.Share;

public abstract class Shape
{
    protected double height;
    protected double width;

    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            height = value;
        }
    }
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            width = value;
        }
    }

    public abstract double Area { get; }
}