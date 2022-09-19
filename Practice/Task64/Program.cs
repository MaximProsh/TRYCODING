// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Write("Input first number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int m = Convert.ToInt32(Console.ReadLine());


string GetNumsSeries(int n, int m)
{
    if (n < m) return $"{n}, " + GetNumsSeries(++n, m);
    
    else return $"{n}";
}

Console.WriteLine(GetNumsSeries(n, m));