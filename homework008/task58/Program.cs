// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int rows1 = Input("Введите количество строк в 1ой матрице- ");
int columns1 = Input("Введите количество столбцов в 1ой матрице - ");
int rows2 = Input("Введите количество строк в 2ой матрице - ");
int columns2 = Input("Введите количество столбцов в 2ой матрице - ");

int[,] matrix1 = new int[rows1, columns1];
int[,] matrix2 = new int[rows2, columns2];

FillArray(rows1, columns1, matrix1);
FillArray(rows2, columns2, matrix2);
Console.WriteLine("Матрица 1:");
WriteArray(rows1, columns1, matrix1);
Console.WriteLine("Матрица 2:");
WriteArray(rows2, columns2, matrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        return;
    }
Console.WriteLine("Матрица 3 = Maтрица 1 * Матрица 2:");
int[,] resultMatrix = Multiplication(matrix1, matrix2);
WriteArray(rows1, columns2, resultMatrix);

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
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