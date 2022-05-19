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
    int rows = 0;
    int columns = 0;
    int temp = 1;
    while (temp <= lenghtCube * lenghtCube)
    {
        array[rows, columns] = temp;
        temp++;
        if (rows <= columns + 1 && rows + columns < lenghtCube - 1)
            columns++;
        else if (rows < columns && rows + columns >= lenghtCube - 1)
            rows++;
        else if (rows >= columns && rows + columns > lenghtCube - 1)
            columns--;
        else 
            rows--;
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