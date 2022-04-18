// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введем координаты двух точек.");

int[] pointA=new int[3];
int[] pointB=new int[3];
pointA = vvodKoordinat(1);
pointB = vvodKoordinat(2);
double result = calculation (pointA, pointB);
Console.WriteLine(result);

int[] vvodKoordinat(int index)
{
    int[] point=new int[3];
    Console.Write($"Введите координату Х{index} -> ");
    point[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату Y{index} -> ");
    point[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату Z{index} -> ");
    point[2] = Convert.ToInt32(Console.ReadLine());
    return point;
}

double calculation (int[] ptA, int[] ptB)
{
    int count = 0;
    double result = 0;
    while (count < 3)
    {
        result = result + Math.Pow((ptB[count] - ptA[count]),2);
        count++;
    }
    return Math.Round(Math.Pow(result, 0.5),2);
}