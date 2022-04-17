// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
Compare(number);

void Compare(int numberIn)
    {
        if (numberIn == 6 ^ numberIn == 7)
        { 
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }