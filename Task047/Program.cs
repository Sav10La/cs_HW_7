// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

void Zadacha47()
{
    int rows = 3;
    int columns = 4;
    double[,] array = new double[rows, columns]; // 4 x 5
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    DecimalRound(array);
}

void FillArray(double[,] array)
{
    Random random = new Random();
    int start = 1;
    int end = 10;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            array[i, j] = random.NextDouble() * (end - start) + start;
        }
    }
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void DecimalRound(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            Console.Write(Math.Round(array[i, j], 1, MidpointRounding.ToEven) + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha47();