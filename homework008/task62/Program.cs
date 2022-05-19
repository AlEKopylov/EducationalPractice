// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
int number = Input("Введите количество строк треугольника Паскаля:");
PascalTriangle(number);

void PascalTriangle(int number)
{
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j <= (number - i); j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k <= i; k++)
        {
            Console.Write($"{factorial(i) / (factorial(k) * factorial(i - k))} ");
        }
        Console.WriteLine();
    }
}
int factorial(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}