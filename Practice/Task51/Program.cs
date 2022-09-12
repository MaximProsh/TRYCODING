// Задача 51. Задайте двумерный массив. Выведите сумму элементов
// главной диагонали.
int[,] CreateRandomArray(int m, int n)
{
    Random rnd = new Random();
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

int[,] array = CreateRandomArray(6,8);
PrintTwoDArray(array);
int sumDiagonal = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == i)
        {
            sumDiagonal += array[i, j];
            Console.Write($"{array[i,j]} ");
        }
    }
}

Console.WriteLine();
Console.WriteLine(sumDiagonal);

