//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через запятую -> ");
int[] numbers = StrToArray(Console.ReadLine());
compareZero(numbers);

void compareZero(int[] array)
{
    int countUpZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countUpZero++;
        }
    } 
    Console.Write(countUpZero);
}

int[] StrToArray(string inputStr)
{
    int countSumNum = 1;
    for(int i = 0; i < inputStr.Length; i++)
    {
        if(inputStr[i] == ',')
        {
            countSumNum++;
        }
    }

    int[] arrayOfNumbers = new int[countSumNum];
    int index = 0;

    for(int i = 0; i < inputStr.Length; i++)
    {
        string tempString = string.Empty;
        
        while (inputStr[i] != ',')
        {
            if(i != inputStr.Length - 1)
            {
                tempString += inputStr[i].ToString();
                i++;
            }
            else
            {
                tempString += inputStr[i].ToString();
                break;
            }
        }
        arrayOfNumbers[index] = Convert.ToInt32(tempString);
        index++;
    }
    return arrayOfNumbers;
}