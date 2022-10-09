// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Эта программа возвращает значение элемента массива, указанного пользователем.");
System.Console.WriteLine("--------------------------------");
Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] Array = new int[5, 5];
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i, j] = new Random().Next(0, 100);
        Console.Write($" {Array[i, j]}");
    }
    Console.WriteLine("\t");
}
Console.WriteLine();

if (m >= Array.GetLength(0) || n >= Array.GetLength(1))
{
    Console.WriteLine($"Введенные значения строки {m} и столбца {n} выходят за пределы массива\n");
}
else
{
    int i = m;
    int j = n;
    Console.WriteLine($"В указанной Вами ячейке ({i},{j}) массива хранится значение: {Array[i, j]}\n");
}
