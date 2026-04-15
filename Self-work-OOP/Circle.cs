class Circle : IShape
{
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Неправильно задан радиус");
        }
        Radius = radius;
    }
    public double Radius { get; set; }
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}




// double TriangleArea(double a, double b, double c)
// {
//     if (a <= 0 || b <= 0 || c <= 0 || (a + b) <= c || (a + c) <= b || (b + c) <= a)
//     {
//         throw new ArgumentException("Invalid triangle sides.");
//     }
//     double s = (a + b + c) / 2;
//     return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
// }

// double RoundArea(double radius)
// {
//     if (radius <= 0)
//     {
//         throw new ArgumentException("Invalid radius.");
//     }
//     return Math.PI * radius * radius;
// }
// try
// {
//     var area = TriangleArea(3, 4, 1);
//     Console.WriteLine($"The area of the triangle is: {area}");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Error: {ex}");
// }
// var roundArea = RoundArea(5);
// Console.WriteLine($"The area of the circle is: {roundArea}");
