using AreaLibrary;
using AreaLibraryTests;

string? shapeType;
IFigure? figure;

string[] validValues = { "1", "2" };

do
{
    Console.WriteLine("Выберите фигуру:");
    Console.WriteLine("1 - круг");
    Console.WriteLine("2 - треугольник");
    Console.WriteLine("q - выход");
    shapeType = Console.ReadLine();

    if (validValues.Contains(shapeType))
    {
        try
        {
            figure = CreateFigure(shapeType);
            Console.WriteLine($"Площадь фигуры равна: {figure.CalculatingArea()}");
            if (figure is Triangle)
            {
                if (((Triangle)figure).RightAngleCheck())
                {
                    Console.WriteLine("Данный треугольник прямоугольный");
                }
                else
                {
                    Console.WriteLine("Данный треугольник не прямоугольный");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }    
    Console.WriteLine();
}
while (shapeType != "q");

static IFigure? CreateFigure(string? shapeType)
{
    IFigure? figure;
    switch (shapeType)
    {
        case "1":
            Console.Write("Введите размер радиуса:");
            double radius = Convert.ToDouble(Console.ReadLine());
            figure = new Circle(radius);
            break;
        case "2":
            Console.Write("Введите размер 1 стороны:");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер 2 стороны:");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер 3 стороны:");
            double sideC = Convert.ToDouble(Console.ReadLine());
            figure = new Triangle(sideA, sideB, sideC);
            break;
        default:
            figure = null;
            break;
    }

    return figure;
}