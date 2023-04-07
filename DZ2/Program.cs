// Задача 2: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе. Реализовать через функции.

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int Sum(int a)
{
    int res = 0;
    while (a > 0)
    {
        res = res + a % 10;
        a = a / 10;
    }
    return res;
}
int a = ReadInt("Введите число");
System.Console.WriteLine($"Сумма чисел в числе {a} равно {Sum(a)}");