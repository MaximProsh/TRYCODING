// Задача 50. Напишите программу, которая на вход принимает число и ищет 
// в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 18 -> нет такого элемента
Console.WriteLine("Input a number: ");
int num = int.Parse(Console.ReadLine());

int[,] newArray = CreateRandomArray(3, 4);
PrintTwoDArray(newArray);
GetIndexesOfNum(newArray, num);

void GetIndexesOfNum(int[,] array, int num)
{
    int[] indexes = new int[2];
    int count = 0;
        
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (newArray[i, j] == num)
            {
                indexes[0] = i;
                indexes[1] = j;
                Console.WriteLine($"Indexes '{num}' is ({indexes[0]} , {indexes[1]})");
                count += 1;       
            }
        }
    }
    if (count == 0)
        {
            Console.WriteLine("There is no this element");
        }
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


