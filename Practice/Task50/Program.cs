// Задача 50. Напишите программу, которая на вход принимает число и ищет 
// в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента
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

int[,] newarray = CreateRandomArray(3, 4);

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

int[,] GetIndexesOfNum(int[,] array, int num)
{
    int[] indexes = new int[2];
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                indexes[0] = i;
                indexes[1] = j;
                break;
            }
        }
        count += 1;
        if (count == array.GetLength(0))
        {
            Console.WriteLine("There is not this element");
        }
    }
    return array;
    
}


PrintTwoDArray(newarray);
GetIndexesOfNum(newarray, 10);

