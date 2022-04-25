// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
///////////////////////////////////////////////////////////////////////////////////////
// Первый способ. Заполнение и вывод массива со случайными числами.
// Console.Write("Введите размер массива -> ");
// int razmer = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[razmer];

// FillArray(numbers);
// WriteArray(numbers);

// void FillArray(int[] array)
// {
//     for (int i =0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,100); 
//     }
// }

// void WriteArray(int[] array)
// {
//     for (int i =0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

///////////////////////////////////////////////////////////////////////////////////////
int[] numbers= new int[8];

for (int i=0; i<numbers.Length; i++)
{
    Console.Write($"Введите число {i+1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
WriteArray(numbers);

void WriteArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        if (i == array.Length-1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
        
    }
    Console.WriteLine();
}