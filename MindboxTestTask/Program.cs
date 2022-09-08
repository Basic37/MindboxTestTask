string? shapeType;

do
{
    Console.WriteLine("Выберите фигуру:");
    Console.WriteLine("1 - круг");
    Console.WriteLine("2 - треугольник");
    Console.WriteLine("q - выход");
    shapeType = Console.ReadLine();
}
while (shapeType != "q");