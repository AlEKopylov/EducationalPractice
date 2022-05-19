// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int N = Input("Введите 1е число - ");
int M = Input("Введите 2е число - ");
Console.Write(SumNumbers(N, M));

int SumNumbers(int N, int M)
{
    if (N < M) return N + SumNumbers(N + 1, M);
    return M;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}