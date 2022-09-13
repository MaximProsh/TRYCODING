// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] newArray = CreateRandomArray(3, 4);
PrintTwoDArray(newArray);
double[] result = AriphmeticAverageOfColumns(newArray);

Console.Write("Arithmetic average of each column: ");
Console.WriteLine(string.Join(", ", result));


double[] AriphmeticAverageOfColumns(int[,] newArray)
{
    double[] allSums = new double[newArray.GetLength(1)];

    for (int i = 0; i < newArray.GetLength(1); i++)
    {
        double result = 0;
        double sumCol = 0;

        for (int j = 0; j < newArray.GetLength(0); j++)
        {
            sumCol += newArray[j, i];
        }
        result = sumCol / newArray.GetLength(0);
        allSums[i] = Math.Round(result, 1);
    }
    return allSums;
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
