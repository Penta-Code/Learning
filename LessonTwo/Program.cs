Rectangle MyRectangle = new (7, 8);

Console.WriteLine($"Rectangle area = {MyRectangle.AreaCalculator()}");

Console.WriteLine($"Rectangle perimetr = {MyRectangle.PerimetrCalculator()}");

Console.WriteLine(MyRectangle);



class Rectangle
{
    private double side1, side2;
    public double Area { get; }
    public double Perimetr { get; }

    public Rectangle()
    {

    }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        return side1 * side2;
    }

    public double PerimetrCalculator()
    {
        return 2 * (side1 + side2);
    }

    public override string ToString()
    {
        return $"P and S = {PerimetrCalculator()} and {AreaCalculator()}";
    }
}