// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
perebor(number);

void perebor(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write(UpToKub(count) + " ");
        count++;
    }
}

double UpToKub(int vhod)
{
    return Math.Pow(vhod, 3);
}

