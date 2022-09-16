// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] newArray = CreateRandomArray(4, 4);
int[,] startArray = newArray;
PrintTwoDArray(startArray);
int[,]result = PlaceRowsNumInArrayFromMaxToMin(newArray);
Console.WriteLine();
PrintTwoDArray(result);


int[,] PlaceRowsNumInArrayFromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array [i, k + 1])
                {
                    int tmp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = tmp;
                }
            }
        }
    }
    return array;
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
