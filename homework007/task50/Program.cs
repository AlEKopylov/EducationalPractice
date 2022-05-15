// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такой элемент отсутствует.

// создание и заполнение массива случайными числами
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int collums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, collums];
FillArray(rows, collums, array);
WriteArray(rows, collums, array);

//поиск элемента
Console.Write($"Введите номер строки: ");
int findRows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите номер столбца: ");
int findCollum = Convert.ToInt32(Console.ReadLine());
if (findCollum <= array.GetUpperBound(1)+1
    & findRows <= array.GetUpperBound(0)+1)
{
    Console.Write($"Ваше число на позиции {findRows}{findCollum} -> {array[findRows - 1, findCollum - 1]}");
}
else Console.Write($"{findRows}{findCollum}-> такого числа в массиве нет"); ;
///////////////////////////////////////////////
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
