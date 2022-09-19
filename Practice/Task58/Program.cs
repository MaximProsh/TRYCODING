// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] arrayA = CreateRandomArray(2, 2);
int[,] arrayB = CreateRandomArray(2, 2);
PrintTwoDArray(arrayA);
Console.WriteLine();
PrintTwoDArray(arrayB);
Console.WriteLine();
int[,] arrayC = new int[arrayA.GetLength(1), arrayB.GetLength(0)];
GetArrayWithMultTwoMatrix(arrayA, arrayB, arrayC);
PrintTwoDArray(arrayC);

int[,] GetArrayWithMultTwoMatrix(int[,] arrayA, int[,] arrayB, int[,] arrayC)
{
    for (int i = 0; i < arrayC.GetLength(0); i++)
  {
    for (int j = 0; j < arrayC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        sum += arrayA[i,k] * arrayB[k,j];
      }
      arrayC[i,j] = sum;
    }    
  }
  return arrayC;
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
