// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());


int[] GetNumsSeriesArray(int[] array, int m, int n, int number = 1)
// Solution via array output
{
    array[number - 1] = m;
    if (m == n) 
    {
        return array;
    }
    else
    {        
        return GetNumsSeriesArray(array, m + 1, n, number + 1);
    }
}

int[] array = new int[n - m + 1];
Console.WriteLine(string.Join(", ", GetNumsSeriesArray(array, m, n)));


string GetNumsSeriesString(int m, int n)
// Solution via string output
{
    if (m < n) return $"{m}, " + GetNumsSeriesString(++m, n);
    
    else return $"{m}";
}
Console.WriteLine(GetNumsSeriesString(m, n));