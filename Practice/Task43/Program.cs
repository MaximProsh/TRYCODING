// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Input b1: ");
bool x = double.TryParse(Console.ReadLine(), out double b1);
Console.Write("Input k1: ");
bool y = double.TryParse(Console.ReadLine(), out double k1);
Console.Write("Input b2: ");
bool z = double.TryParse(Console.ReadLine(), out double b2);
Console.Write("Input k2: ");
bool w = double.TryParse(Console.ReadLine(), out double k2);

if (!x || !y || !z || !w)
{
    Console.WriteLine("Invalid input");
}
else
{
    GetPointIntersectionTwoLines(b1, k1, b2, k2);
}

void GetPointIntersectionTwoLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Lines are parallel");
    }
    else
    {  
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"The point of lines intersection: ({x}:{y})");
    }
}



