//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает.
//Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.

// выделяю диапазон
Console.Write(" Введи минимальное число -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введи максимальное число -> ");
int max = Convert.ToInt32(Console.ReadLine());

if (min < max) // проверка вводных данных
{
    int randNumber = new Random().Next(min, (max + 1));
    //Console.WriteLine(randNumber); // раскомментировать для проверки
    Console.Write(" Я загадал число от " + min + " до " + max + ". Угадай, есть 3 попытки -> ");
    int number = Convert.ToInt32(Console.ReadLine());
    Compare(randNumber, number); // запуск проверки чисел
}
else
{
    Console.WriteLine(" Ошибка! ");
}


void Compare (int numberMy, int numberIn)
    {
        int count = 2;
        while (count >= 0)
        {
            if (numberMy == numberIn)
            {
                Console.Write("!УГАДАЛ!");
                break;
            }
            else
            {
                if (count == 0)
                {
                    Console.Write("Неугадал :( Мое число - " + numberMy);
                    break;
                }
                if (numberMy > numberIn)
                {
                    Console.Write("Мое число больше, попробуй еще, осталось попыток " + count + " -> ");
                    numberIn = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Мое число меньше, попробуй еще, осталось попыток " + count + " -> ");
                    numberIn = Convert.ToInt32(Console.ReadLine());
                }
                count--;
            }
        }
    }