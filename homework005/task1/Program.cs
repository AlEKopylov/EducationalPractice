Console.Write("Введите размер массива -> ");
int razmer = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[razmer];

FillArray(numbers);
WriteArray(numbers);
Console.Write($"Четных чисел в массиве: {FindEvenNumber(numbers)}.");

void FillArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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

int FindEvenNumber(int[] array)
{
    int count = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            count++;
        }
    }
    return count;
}