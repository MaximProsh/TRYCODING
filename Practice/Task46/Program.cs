// Задача 46. Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.

int[,] CreateRandomArray()
{
    Random rnd = new Random();
    int m = rnd.Next(2, 5);
    int n = rnd.Next(2, 5);

    int[,] array = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(1,99);
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
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}

PrintTwoDArray(CreateRandomArray());