namespace Packt.Share;

public class Circle : Shape
{
    protected double radius;

    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
        }
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area
    {
        get
        {
            return Math.PI * (radius * radius);
        }
    }
}
