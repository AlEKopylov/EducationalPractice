// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Найдем точку пересечения между прямыми.");
Console.Write("k1 - > ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 - > ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 - > ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 - > ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

double x = (b2 - b1)/(k1-k2);
double y = (b1*k2 - b2*k1)/(k2-k1);
//double y = k2*x +b2; // либо так

Console.WriteLine($"x = {x}, y = {y}");