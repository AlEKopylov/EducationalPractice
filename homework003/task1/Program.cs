// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число -> ");
string number = Console.ReadLine();

if (number.Length != 5)
{
    Console.Write("Введите пятизначное число!");
    return;
}

checkNumber(number);

void checkNumber (string Chislo)
{
    int countMin = 0, countMax= 4;
    if (Compare(Chislo[countMin], Chislo[countMax]) == true) 
    {
        if (Compare(Chislo[countMin+1], Chislo[countMax-1]) == true)
        {
            Console.Write("Да");
        }
        else
        {
            Console.Write("Нет");
        }
    }
    else
    {
        Console.Write("Нет");
    }

    
}

bool Compare (char symbolOne, char symbolTwo)
{
    if (symbolOne == symbolTwo)
    {
        return true;
    }
    else
    {
        return false;
    }

}