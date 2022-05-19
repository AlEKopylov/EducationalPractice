// Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int lenghtCube = Input("Введите длину квадратного массива - ");
int[,] arrayOfNumbers = new int[lenghtCube, lenghtCube];

FillArrayBy(lenghtCube, arrayOfNumbers);
WriteArray(lenghtCube, arrayOfNumbers);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayBy(int lenghtCube, int[,] array)
{
    int i = 0;
    int j = 0;
    int temp = 1;
    while (temp <= lenghtCube * lenghtCube)
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < lenghtCube - 1)
            j++;
        else if (i < j && i + j >= lenghtCube - 1)
            i++;
        else if (i >= j && i + j > lenghtCube - 1)
            j--;
        else 
            i--;
    }
}
void WriteArray(int lenghtCube, int[,] array)
{
    for (int i = 0; i < lenghtCube; i++)
    {
        for (int j = 0; j < lenghtCube; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
