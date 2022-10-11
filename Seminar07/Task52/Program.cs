// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
System.Console.WriteLine("Задан следующий массив:\n");
int[,] Array = new int[5, 5];
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i, j] = new Random().Next(0, 10);
        Console.Write($" {Array[i, j]}");
    }
    Console.WriteLine("\t");
}
Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое столбцов равно:");
double[] ArrResult = new double[Array.GetLength(1)];
double Result = 0;
for (int j = 0; j < Array.GetLength(0); j++)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        Result = Result + Array[i,j];
       //System.Console.Write(Result+" ");
    }

    ArrResult[j] = Result/Array.GetLength(1); 
    Console.Write($"столбец {j} = {ArrResult[j]}");
    Result=0;
    System.Console.WriteLine("");
}
System.Console.WriteLine("====================================");