// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
//  Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  Реализовать через функции.
//   (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”,
// “Введите максимальный порог случайных значений”)

int[] CreateArray(int cool, int min, int max)
{
    int[] res = new int[cool];
    for (int i = 0; i < cool; i++)
    {
        res[i] = new Random().Next(min, max + 1);
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
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int cool = ReadInt("Введите колличество элементов");
int min = ReadInt("Введите минимальный порог массива");
int max = ReadInt("Введите максимальный порог массива");
int[] massive = CreateArray(cool, min, max);
PrintArray(massive);
