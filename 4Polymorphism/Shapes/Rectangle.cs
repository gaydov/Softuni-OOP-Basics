public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    private double Height { get; }

    private double Width { get; }

    public override double CalculatePerimeter()
    {
        return (2 * this.Height) + (2 * this.Width);
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
