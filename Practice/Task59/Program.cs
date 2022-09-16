// Задача 59. Задайте двумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечени
// которых находится наименьший элемент массива.
int[,] startArray = CreateRandomArray(3, 8);
PrintTwoDArray(startArray);
Console.WriteLine();
int[] iMinNum = GetIndexesMinNum(startArray);
Console.WriteLine(String.Join(", ", iMinNum));
Console.WriteLine();
int[,] result = DelRowAndColumnWithMinNum(startArray);
PrintTwoDArray(result);

int[,] DelRowAndColumnWithMinNum(int[,] array)
{
    // delete the row
    int[,] prefinishArray = new int[startArray.GetLength(0) - 1, startArray.GetLength(1)];

    int icount = 0;
    for (int i = 0; i < startArray.GetLength(0); i++)
    {
        if (i == iMinNum[0])
        {
            continue;
        }
        
        for (int j = 0; j < startArray.GetLength(1); j++)
        {
            prefinishArray[icount, j] = startArray[i, j];
        }
        icount ++;
    }

    //delete the column
    int[,] finishArray = new int[prefinishArray.GetLength(0), prefinishArray.GetLength(1) - 1];

    for (int i = 0; i < prefinishArray.GetLength(0); i++)
    {
        int jcount = 0;
        for (int j = 0; j < prefinishArray.GetLength(1); j++)
        {
            if (j == iMinNum[1])
            {
                continue;
            }
            finishArray[i, jcount] = prefinishArray[i, j];
            jcount ++;
        }
        
    }
    return finishArray;
}

int[] GetIndexesMinNum(int[,] array)
{
    int min = startArray[0, 0];
    int[] iminArray = new int[2];

    for (int i = 0; i < startArray.GetLength(0); i++)
    {
        for (int j = 0; j < startArray.GetLength(1); j++)
        {
            if (startArray[i,j] < min)
            {
                min = startArray[i, j];
                iminArray[0] = i;
                iminArray[1] = j;
            }
        }
    }
    return iminArray;
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