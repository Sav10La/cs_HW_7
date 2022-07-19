// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

void Zadacha50()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns]; // 4 x 5
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Position(array);    
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
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

void Position(int[,] array)
{
    Console.Write("Введите строку: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец: ");
    int b = Convert.ToInt32(Console.ReadLine());
    

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    if (a == 0 || b == 0 || a > rows || b > columns)
    {
        Console.WriteLine("Нет такого элемента!");
    }
    else if (a <= rows || b <= columns)
    {
        int number = array[a - 1, b - 1];
        Console.WriteLine(number);
    }

}

Zadacha50();