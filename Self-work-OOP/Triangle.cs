class Triangle : IShape
{
    public Triangle(double first, double second, double third)
    {
        if (first <= 0 || second <= 0 || third <= 0 || (first + second) <= third || (first + third) <= second || (second + third) <= first)
            throw new ArgumentException("Некорректные стороны треугольника.");
        First = first;
        Second = second;
        Third = third;
    }
    public double First { get; set; }
    public double Second { get; set; }
    public double Third { get; set; }
    public bool IsRightTriangle()
    {
        double[] sides = new[] { First, Second, Third };
        Array.Sort(sides);
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
    }
    public double GetArea()
    {
        double s = (First + Second + Third) / 2;
        return Math.Sqrt(s * (s - First) * (s - Second) * (s - Third));
    }
}