// Напишите программу, которая принимает на вход числа и выдает сумму цифр в числе.

Console.Write("Введите число -> ");
string number = Console.ReadLine();
Console.Write($"Сумма чисел в массиве: {findSum(number)}.");


int findSum(string numberToSum)
{
    int result = 0,
        len = numberToSum.Length;
    int numberToSumInt = Convert.ToInt32(numberToSum);
    for (int i =0; i < len; i++)
    {
        result = result + (numberToSumInt/AnalogPow(10, i)%10);
    }
    return result;
}

int AnalogPow(int osnovanieStepeni, int pokazatelStepeni)
{
    int result = 1;
    for (int i =0; i < pokazatelStepeni; i++)
    {
        result = result * osnovanieStepeni; 
    }
    return result;
}