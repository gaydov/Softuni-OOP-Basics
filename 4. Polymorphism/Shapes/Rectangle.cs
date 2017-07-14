public class Rectangle : Shape
{
    private double Height { get; set; }
    private double Width { get; set; }

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * this.Height + 2 * this.Width;
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
