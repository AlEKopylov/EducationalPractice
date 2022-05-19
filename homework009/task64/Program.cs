// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
int N = Input("Введите N - ");
NaturalOutput(N);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int NaturalOutput(int number)
{
    Console.Write($"{number} ");
    if (number > 1) return NaturalOutput(number-1);
    return 1;
}