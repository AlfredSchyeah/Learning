static void PrintArea(IShape shape)
{
    Console.WriteLine(shape.GetArea());
}

static void IsRightTriangle(Triangle IsRight)
{
    Console.WriteLine(IsRight.IsRightTriangle());
}

try
{
    PrintArea(new Circle(5));
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

try
{
    var triangle = new Triangle(3, 4, 5);
    PrintArea(triangle);
    Console.WriteLine(triangle.IsRightTriangle());
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

var shapes = new List<IShape>
{
    new Circle(5),
    new Triangle(3, 4, 5),
    new Circle(2),
    new Triangle(6, 8, 10),
    new Circle(10),
    new Triangle(5, 5, 5),
};

var shapesArea = shapes.OrderBy(s => s.GetArea());
foreach (var c in shapesArea)
    Console.WriteLine(c.GetArea());

var maxValue = shapesArea.Max(s => s.GetArea());
Console.WriteLine(maxValue);

var Area50 = shapes.Where(s => s.GetArea() >= 50);
foreach (var a in Area50)
    Console.WriteLine($"Фигуры с площадью более 50 это {a} = {a.GetArea()}");