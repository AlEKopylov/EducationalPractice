// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите 3хзначное число ");
int number=Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.Write(result);