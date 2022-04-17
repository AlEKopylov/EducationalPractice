// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(RezakNumber(number));

int RezakNumber(int numberToRez)
    {
        int result = (numberToRez / 10)%10;
        return result;
    }