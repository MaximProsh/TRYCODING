//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("How many numbers will you enter? ");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if(!isNumber || length == 0)
{
    Console.WriteLine("Invalid input");
}

int[] result = FillArrayFromUserInput(length);
Console.WriteLine(string.Join(",", result));
Console.WriteLine(SumPositiveNumsInSequence(result));

int[] FillArrayFromUserInput(int length)
{
    int[] array = new int[length];
    Console.WriteLine("Input your numbers for the array:");
    for (int i = 0; i < length; i++)
    {
        bool userInput = int.TryParse(Console.ReadLine(), out int tmp);
        if (!userInput)
        {
            throw new Exception("Invalid input");
        }
        else
        {
            array[i] = tmp;
        }
    }
    return array;
}

int SumPositiveNumsInSequence(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

