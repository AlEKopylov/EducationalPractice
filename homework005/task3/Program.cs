// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива -> ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[razmer];

FillArray(numbers);
WriteArray(numbers);
Console.Write($"Разница между Max и Min массива: {MaxMinusMin(numbers)}.");

void FillArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100); 
    }
}

void WriteArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int MaxMinusMin(int[] array)
{
    int max = array[0],
        min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        else if (max < array[i])
        {
            max = array[i];
        }
    }
    return max-min;
}