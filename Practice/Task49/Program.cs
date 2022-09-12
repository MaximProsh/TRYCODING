// Задача 49. Задайте двумерный массив. Найдите элементы, у которых
// оба индекса четные, и замение эти элементы на их квадраты.

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

int[,] arraySqrt = CreateRandomArray(6, 8);
PrintTwoDArray(arraySqrt);


for (int i = 2; i < arraySqrt.GetLength(0); i += 2)
{
    for (int j = 2; j < arraySqrt.GetLength(1); j += 2)
    {
        
        {
            arraySqrt[i,j] = arraySqrt[i,j] * arraySqrt[i,j];
        }
    }
}

Console.WriteLine();
PrintTwoDArray(arraySqrt);