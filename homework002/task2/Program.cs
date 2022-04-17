// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число -> ");
string number = Console.ReadLine();

if (number.Length >= 3)
{
    Console.WriteLine(RezakNumber(number));
}
else
{
    Console.WriteLine("третьей цифры нет");
}

char RezakNumber(string numberToRez)
    {
        char result = numberToRez[2];
        return result;
    }