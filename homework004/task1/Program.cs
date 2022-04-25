//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А -> ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B -> ");
int numberB = Convert.ToInt32(Console.ReadLine());
checkNatural(numberB);

AnalogPow(numberA, numberB);
Console.Write($"Число {numberA} в степени {numberB} = {AnalogPow(numberA, numberB)}.");
Console.WriteLine();
//Console.WriteLine($"Проверка = {Math.Pow(numberA, numberB)}."); // добавил проверку через Math.Pow

int AnalogPow(int osnovanieStepeni, int pokazatelStepeni)
{
    int result = 1;
    for (int i =0; i < pokazatelStepeni; i++)
    {
        result = result * osnovanieStepeni; 
    }
    return result;
}

void checkNatural(int pokazatelToCheck)
{
    if (pokazatelToCheck < 0)
        {
            numberB = pokazatelToCheck * -1;
        }
}