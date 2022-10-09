// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// установить размерность массива
// создать двухмерный массив, рандомно заполнить вещественными числами
// вывести его на печать

Console.Clear();
Console.WriteLine("Массив вещественных чисел: ");
int m = 3;
int n = 4;

double[,] Array = new double[m, n];
Random rnd = new Random();

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i, j] = Math.Round((rnd.NextDouble() * (10 - (-10)) + (-10)), 1);
        Console.Write($" {Array[i, j]}");
    }
    Console.WriteLine("\t");
}
Console.WriteLine();

