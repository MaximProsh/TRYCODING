// Задача 65. Задайте значения M и N. Напишите программу,
// которая выведет все значения от M до N.
Console.Write("Input first number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] f(int n, int m)
{
    int count = 0;
    int[] arr = new int[m - n + 1];
    for (int i = n; i < m + 1; i++)
    {
        arr[count] = i;
        count ++;
    }
    return arr;
}

Console.WriteLine(string.Join(", ", f(n, m)));