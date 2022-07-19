// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void Zadacha52()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns]; // 4 x 5
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Mean(array);    
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

// Функция для расчета среднего арифметического каждого столбца
void Mean(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double sum = 0;
    double mean = 0;
    // нахождение суммы и среднеарифметического столбца
    for (int j = 0; j < columns; ++j)
    {
        for (int i = 0; i < rows; ++i)
        {
            // добавление элемента
            sum = sum + array[i, j];
            mean = sum / (i + 1);
        }
        // Печать среднеарифметического
        Console.WriteLine("Среднеарифметическое столбца " + j + " = " + Math.Round(mean, 1, MidpointRounding.ToEven)); // округление до десятых
        // Обнуляем сумму
        sum = 0;
    }
}

Zadacha52();