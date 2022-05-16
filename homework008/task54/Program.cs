// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int rows = Input("Введите количество строк в массиве - ");
int columns = Input("Введите количество столбцов в массиве - ");
int[,] arrayOfNumbers = new int[rows, columns];

FillArray(rows, columns, arrayOfNumbers);
WriteArray(rows, columns, arrayOfNumbers);
arrayOfNumbers = SortRows(arrayOfNumbers);
Console.WriteLine("");
WriteArray(rows, columns, arrayOfNumbers);

int[,] SortRows(int[,] array)
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
        {
            int maxNumber = array[i, j];
            int indexMaxNumber = j;
            for (int k = j ; k < array.GetUpperBound(1) + 1; k++)
            {
                if (maxNumber < array[i, k])
                {
                    maxNumber = array[i, k];
                    indexMaxNumber = k;
                }
            }
            array[i,indexMaxNumber] = array[i,j];
            array[i,j] = maxNumber;
        }
    }
    return array ;
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
            array[i, j] = new Random().Next(0, 10);
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