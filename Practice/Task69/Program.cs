// Задача 69. Напишите программу, которая на вход принимает два числа A и B,
// и возводит число A в целую степень B с помощью рекурсии.

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int f(int a, int b)
{
    if (b == 1) 
        return a;
    else
        return a * f(a, b - 1);
}

int x = f(a, b);
Console.WriteLine(x);