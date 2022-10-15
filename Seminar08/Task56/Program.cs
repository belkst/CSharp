/*Задача 56:
Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int SizeArray()//метод запрашивает и возвращает количество элементов массива, число больше 1
{
    Console.Write("Введите размерность массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    while (size < 2)
    {
        Console.WriteLine("Вы ввели неверное значение (меньше 2-х), пожалуйста, повторите ввод:");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    return size;
}

int[,] NumArray(int size) // fill random and print array
{
    int[,] newArray = new int[size, size];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 9);
            Console.Write(newArray[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return newArray;
}

int[] SumArray(int[,] numArray)//fill new array in sum 
{
    int[] sumArray = new int[numArray.GetLength(0)];
    for (int i = 0; i < numArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numArray.GetLength(1); j++)
        {
            sum = sum + numArray[i, j];
        }
        sumArray[i] = sum;
        Console.WriteLine("Сумма строки "+i+" = "+sum);
    }
    return sumArray;
}

void MinResult(int[] sumArray) //
{
    int min = sumArray[0];
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < min) min = sumArray[i];
    }
    Console.Write("Строка, с минимальным значением суммы: ");
    for (int i = 0; i < sumArray.Length; i++)
{
    if (sumArray[i]==min) Console.Write(i + " ");
}
}

int[] arr = SumArray(NumArray(SizeArray()));
MinResult(arr);
Console.WriteLine("");



