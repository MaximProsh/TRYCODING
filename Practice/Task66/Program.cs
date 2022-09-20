// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumFromAtoB(m, n));

int GetSumFromAtoB(int a, int b)
{
    if (a == b - 1)
    {
        return a + b;
    }
    else return a + GetSumFromAtoB(a + 1, b);
}
