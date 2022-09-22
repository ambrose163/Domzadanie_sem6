// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.

Console.Write("b1 = ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("k1 = ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("b2 = ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("k2 = ");
int k2 = int.Parse(Console.ReadLine()!);

SolveAnEquation(b1, k1, b2, k2);

void SolveAnEquation(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают - бесконечное множество решений");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельны - задача не имеет решений");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"({x}; {y})");
    }     
}