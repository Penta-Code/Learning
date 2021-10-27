Rectangle MyRectangle = new (7, 8);

Console.WriteLine($"Rectangle area = {MyRectangle.AreaCalculator()}");

//Console.WriteLine($"Rectangle perimetr = {MyRectangle.PerimetrCalculator()}");

Console.WriteLine(MyRectangle);


class Rectangle
{
    double side1, side2;
    double Area { get; }
    double Perimetr { get; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        double S = side1 * side2;
        return S;
    }

    public double PerimetrCalculator()
    {
        double P = 2 * (side1 + side2);
        return P;
    }

    public override string ToString()
    {
        return $"P and S = {PerimetrCalculator()} and {AreaCalculator()}";
    }
}