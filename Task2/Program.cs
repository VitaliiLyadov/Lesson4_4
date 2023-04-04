// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumDigits(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum = sum * i;
    }
    return sum;
}

int value = ReadInt("Введите число");

int sum = SumDigits(value);
System.Console.WriteLine($"Произведение числа {value} равна {sum}");