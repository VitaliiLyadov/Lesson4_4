// Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray()
{
    int res = 0;
    for (int i = 0; i < 8; i++)
    {
        res[i] = new Random().Next(0, 2);
    }
    return res;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
int Count(int[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            count++;
        }
    }
    return count;
}
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int value = ReadInt("Введите число");
int[] massive = CreateArray();
System.Console.WriteLine($"колличество {value} равно {Count(massive, value)}");
int[] massive = CreateArray();