// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] newArray = CreateRandomArray(3, 4);
PrintTwoDArray(newArray);

int sumCol = 0;

for (int i = 0; i < newArray.GetLength(0); i++)
{
    sumCol += // завис тут

    for (int j = 0; j < newArray.GetLength(1); j++)

    {

        while (i == tmpIndex)
        {
            sumCol += newArray[i,j];
            Console.WriteLine(sumCol);
        }
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
