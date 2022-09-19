// Задача 63. Задайте число N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] f(int num)
{
    int[] arr = new int[num];
    for (int i = 1; i < num + 1; i++)
    {
        arr[i - 1] = i;
    }
    return arr;
}

Console.WriteLine(string.Join(", ", f(num)));