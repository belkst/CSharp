/* 
Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.WriteLine("============================");

int[,] a = new int[,]
{
    {2,4},
    {3,2}
};
int[,] b = new int[,]
{
    {3,4},
    {3,3}
};

int[,] c = new int[a.GetLength(0), b.GetLength(1)];
System.Console.WriteLine(a.GetLength(1) + " столбцов в А массиве");
System.Console.WriteLine(b.GetLength(0) + " строк в В массиве");

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(1); k++)
        {
            c[i, j] += a[i, k] * b[k, j]; // c[i,j] += a[i, k] * b[k,j]
        }
    }
}

Console.WriteLine("Матрица А");
Console.WriteLine("---------");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Матрица B");
Console.WriteLine("---------");

for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        Console.Write(b[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


System.Console.WriteLine("Результат перемножения матриц А и В");
System.Console.WriteLine("Матрица С");
System.Console.WriteLine("---------");

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        Console.Write(c[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");