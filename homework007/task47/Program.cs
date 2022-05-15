// Задать двумерный массив размером m x n, заполненный случайными вещественными числами. 
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
FillArray(m, n, array);
WriteArray(m, n, array);
///////////////////////////////////////////////
void FillArray(int m, int n, double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 101) / 10.0); // получаем генерацию случайных вещественных чисел от -10 до 10
        }
    }
}
void WriteArray(int m, int n, double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}