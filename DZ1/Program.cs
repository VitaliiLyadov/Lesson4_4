// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B. Реализовать через функции.
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int NaturalDegree(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}
int A = ReadInt("Введите число A");
int B = ReadInt("Введите число B");

System.Console.WriteLine($"{A} в степени {B} равно {NaturalDegree(A, B)}");