// Задача 31: Задайте массив из 12 элементов, заполненный случайными
//  числами из промежутка [-9, 9]. Найдите сумму отрицательных и
//   положительных элементов массива.
// ===
// 1 создать массив из 12 элементов
// 2 заполнить случайными числами
// печать
// найти сумму положительных
// найти сумму отрицательных
// найти их сумму



Console.Clear();

int[] FillArray()
{
    int[] arr = new int[12];
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int SumP(int[] sp)
{
    int suP = 0;
    for (int i = 0; i < sp.Length; i++)
    {
        if (sp[i] > 0)
        {
            suP += sp[i]; // sumP = sumP + array[i];
        }
    }
    return suP;
}
int SumN(int[] sn)
{
    int suN = 0;
    for (int i = 0; i < sn.Length; i++)
    {
        if (sn[i] < 0)
        {
            suN += sn[i];
        }
    }
    return suN;
}

Console.WriteLine("Создан массив из 12 элементов");
Console.WriteLine(string.Join(", ", FillArray()));
Console.WriteLine($"сумма положительных чисел = {SumP(FillArray())}");
Console.WriteLine($"сумма отрицательных чисел = {SumN(FillArray())}\n");