// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int siceMassive()//метод запрашивает и возвращает количество элементов массива
{
    Console.WriteLine("Ниже напишите количество элементов массива:");
    int sizeMass = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введенное Вами количество элементов массива: " + sizeMass);
    return sizeMass;
}


int[] randMass(int sice) //создает и заполняет массив псевдослучайными числами
{
    int[] massive = new int[sice];
    Random rand = new Random();

    for (int v = 0; v < sice; v++)
    {
        massive[v] = rand.Next(100, 999);
        Console.WriteLine("Значение элемента массива " + v + " = " + massive[v]);
    }
    return massive;
}

    
void result (int[] massive) //вычисляем количество четных чисел 
{
    int res = 0;
    int zice = massive.Length;
    for (int j=0; j<zice; j++)
    {
        if (massive[j]%2==0) res++;
    }
    Console.WriteLine("Количество четных чисел в массиве составляет: "+res);
}

int sice = siceMassive();
result(randMass(sice));
System.Console.WriteLine();