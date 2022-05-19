// Задание 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int rows = Input("Введите количество строк в массиве - ");
int columns = Input("Введите количество столбцов в массиве - ");
int[,] arrayOfNumbers = new int[rows, columns];
int temp = 1;

FillArray(arrayOfNumbers);
WriteArray(arrayOfNumbers);

while (temp == 1)
{
    arrayOfNumbers = StartFind(arrayOfNumbers);
    if (arrayOfNumbers.GetUpperBound(0)==0) return;
    temp = Repeat("хотите продолжить? 0 - нет, 1 - да -> ");
}

int[,] StartFind(int[,] arrayOfNumbers)
{
    int[] indexMinimalNumber = FindMinimumOfArray(arrayOfNumbers);
    arrayOfNumbers = DeleteMinimalRowsColomns(arrayOfNumbers, indexMinimalNumber[0], indexMinimalNumber[1]);
    Console.WriteLine($"Наименьший элемент {indexMinimalNumber[2]}, на выходе получаем следующий массив: ");
    WriteArray(arrayOfNumbers);
    return arrayOfNumbers;
}

int Repeat(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =new Random().Next(3, 10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] FindMinimumOfArray(int[,] array)
{
    int minimalNumber = array[0, 0];
    int[] indexMinimalNumberOfArray = new int[3];
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
        {
            if (minimalNumber > array[i, j])
            {
                indexMinimalNumberOfArray[0] = i;
                indexMinimalNumberOfArray[1] = j;
                minimalNumber = array[i, j];
            }
        }
    }
    indexMinimalNumberOfArray[2] = minimalNumber;
    return indexMinimalNumberOfArray;
}

int[,] DeleteMinimalRowsColomns(int[,] array, int minimalRow, int minimalColumn)
{
    int countRowsNewArray = 0, countColumnNewArray = 0;
    int[,] updateArray = new int[array.GetUpperBound(0), array.GetUpperBound(1)];
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
    {
        if (i == minimalRow)
        {
            continue;
        }
        for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
        {
            if (j != minimalColumn)
            {
                updateArray[countRowsNewArray, countColumnNewArray] = array[i, j];
                countColumnNewArray++;
                if (countColumnNewArray == array.GetUpperBound(1))
                {
                    countColumnNewArray = 0;
                    countRowsNewArray++;
                }
            }

        }
    }
    return updateArray;
}