//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int rows = Input("Введите количество строк в массиве - ");
int columns = Input("Введите количество столбцов в массиве - ");
int[,] arrayOfNumbers = new int[rows, columns];

FillArray(rows, columns, arrayOfNumbers);
WriteArray(rows, columns, arrayOfNumbers);
int[] rowWithMinimalSum = FindRowWithMinSum(arrayOfNumbers);
Console.WriteLine("");
Console.Write($"Минимальная сумма {rowWithMinimalSum[0]} найдена в строке {rowWithMinimalSum[1]+1}");

int[] FindRowWithMinSum(int[,] array)
{
    int[] result = new int[2];
    result[0] = 0;
    result[1] = 0;
    int tempSum = 0;
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
        {
            tempSum += array[i, j];
        }
        if (tempSum < result[0] | i == 0)
        {
            result[0] = tempSum; 
            result[1] = i;
        }
        tempSum = 0;
    }
    return result;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int rows, int columns, int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 3);
        }
    }
}

void WriteArray(int rows, int columns, int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}