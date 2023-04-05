// Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray()
{
    int[] res = new int[8];
    for (int i = 0; i < res.Length; i++)
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
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1)
        {
            count++;
        }
    }
    return count;
}
int[] massive = CreateArray();
System.Console.WriteLine($"колличество единиц равно {Count(massive)}");
PrintArray(massive);