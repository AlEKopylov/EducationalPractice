// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Название переменных взял по системе координат:)
int x = Input("Введите 1 число - ");
int y = Input("Введите 2 число - ");
int z = Input("Введите 2 число - ");
int[,,] arrayOfNumbers = new int[x, y, z];
FillArray(arrayOfNumbers);
WriteArray(arrayOfNumbers);

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(0, 10);
            }
        }
    }
}
void WriteArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                 Console.Write($" |{array[i, j, k]} - ({i},{j},{k})");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine();
    }
}