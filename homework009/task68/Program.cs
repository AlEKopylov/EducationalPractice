// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int M = Input("Введите M - ");
int N = Input("Введите N число - ");
Console.Write(AckermannFunction(M, N));

int AckermannFunction(int M, int N)
{
    if (M > 0 && N == 0) return AckermannFunction(M - 1, 1);
    else if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    return N + 1;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}