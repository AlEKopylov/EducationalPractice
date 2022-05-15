// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// создание и заполнение массива случайными числами
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayOfNumbers = new int[m, n];
FillArray(m, n, arrayOfNumbers);
WriteArray(m, n, arrayOfNumbers);
// Поиск среднеарифметического по столбцам
double[] meanOfCollums = new double[arrayOfNumbers.GetUpperBound(1) + 1];
for (int j = 0; j <= arrayOfNumbers.GetUpperBound(1); j++)
{

    for (int i = 0; i <= arrayOfNumbers.GetUpperBound(0); i++)
    {
        meanOfCollums[j] += arrayOfNumbers[i, j];
    }
    meanOfCollums[j] /= arrayOfNumbers.GetUpperBound(0) + 1;
}
Console.Write("");
Console.Write("Средне арифметическое каждого столбца: ");
for (int i = 0; i < meanOfCollums.GetUpperBound(0) + 1; i++)
{
    Console.Write(Math.Round(meanOfCollums[i], 2) + " ");
}

void FillArray(int m, int n, int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 10); // получаем генерацию случайных вещественных чисел от -10 до 10
        }
    }
}
void WriteArray(int m, int n, int[,] array)
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
