namespace Packt.Share;

public class Square : Shape
{
    public Square(double height)
    {
        this.height = height;
    }

    public override double Area
    {
        get
        {
            return height * height;
        }
    }
}
