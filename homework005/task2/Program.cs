// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

Console.Write("Введите размер массива -> ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[razmer];

FillArray(numbers);
WriteArray(numbers);
Console.Write($"Cумма элементов на нечетных позициях массива: {SumFromArray(numbers)}.");

void FillArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,11); // диапазон можно увеличить, для удобства оставил от -10 до 10
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

int SumFromArray(int[] array)
{
    int result = 0;
    for (int i =1; i < array.Length; i=i+2)
    {
        result += array[i];
    }
    return result;
}