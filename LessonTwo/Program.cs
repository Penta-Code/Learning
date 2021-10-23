class Rectangle
{
    double side1, side2;

    double Side1 { get; }
    double Side2 { get; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    double AreaCalculator(double side1, double side2)
    {
        double S = 0.5 * side1 * side2;
        return S;
    }

    double PerimetrCalculator(double side1, double side2)
    {
        double perimetr = (side1 * 2) + (side2 * 2);
        return perimetr;
    }
}