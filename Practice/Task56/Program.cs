// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
int[,] array = CreateRandomArray(5, 3);
PrintTwoDArray(array);
int lineNumWithMinSum = GetNumOfRowWithMinElementSum(array);
Console.WriteLine($"The line number with minimal sum of elements: {lineNumWithMinSum}");

int GetNumOfRowWithMinElementSum(int[,] array)
{
    int[] sumsInAllRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumInRow = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumInRow += array[i, j];
        }
        sumsInAllRows[i] = sumInRow;
    }

    int minNum = sumsInAllRows[0];
    int lineNumWithMinSum = 0;
    for (int i = 0; i < sumsInAllRows.Length; i++)
    {
        if (sumsInAllRows[i] < minNum)
        {
            minNum = sumsInAllRows[i];
            lineNumWithMinSum = i;
        }
    }
    return lineNumWithMinSum + 1;
}

int[,] CreateRandomArray(int m, int n)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}

void PrintTwoDArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
