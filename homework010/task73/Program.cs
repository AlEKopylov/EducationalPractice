// Task 37. Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты 
// (все числа в группе друг на друга не делятся)? Найдите M при заданном N и 
// получите одно из разбиений на группы N ≤ 10²⁰. Можно использовать рекурсию.
// Например, для N = 50, M получается 6
// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48
// Или
// Группа 1: 1
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 16 24 36 40
// Группа 6: 32 48
int n = Input("Введите число N: ");
int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

int countNumbers = 0;
int countGroups = 0;

while(countNumbers != n)
{
    int[] tempArray = new int[1];
    if(countNumbers == 0)
    {
        tempArray[0] = numbers[countNumbers];
        numbers[countNumbers] = 0;
        countNumbers++;
        countGroups++;
        PrintArray(tempArray);
        continue;
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == 0)
        {
            continue;
        }
        if(tempArray.Length == 1 && tempArray[0] == 0)
        {
            tempArray[0] = numbers[i];
            numbers[i] = 0;
            countNumbers++;
            continue;
        }
        else if(tempArray[0] != 0)
        {
            bool access = true;
            for (int j = 0; j < tempArray.Length; j++)
            {
                if(!CheckNumbers(numbers[i], tempArray[j]))
                {
                    access = false;
                    break;
                }
            }
            if(access)
            {
                Array.Resize(ref tempArray, tempArray.Length + 1);
                tempArray[tempArray.Length - 1] = numbers[i];
                countNumbers++;
                numbers[i] = 0;
            }
        }
    }
    countGroups++;
    PrintArray(tempArray);
}

bool CheckNumbers(int number1, int number2)
{
    int nod;
    while(number1 != number2)
    {
        if(number1 > number2)
        {
            number1-= number2;
        }
        else
        {
            number2 -= number1;
        }
    }
    nod = number2;

    if(nod == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Группа {countGroups}: ");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}