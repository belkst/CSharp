// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// запросить количество элементов массива
// создать и заполнить массив вещественными числами
// найти Мах и Мин, присвоить их значния переменным
// посчитать разницу и вывести в консоль

Console.Clear();

int sizeArray()//метод запрашивает и возвращает количество элементов массива, число больше 1
{
    Console.Write("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    while (size < 1)
    {
        Console.WriteLine("Вы ввели неверное значение (0 или отрицательное), пожалуйста, повторите ввод:");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
   
    return size;
}

int[] fillArray(int size) //заполняем массив случайными числами
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;  
        array[i] = new Random().Next(0, 9999);
        Console.WriteLine($"Элемент массива {i} = {array[i]}");
        Console.ResetColor();
    }
    return array;
}

int maxElement(int[] array)  //метод возвращает максимальный элемент массива
{
    int max = array[0];
    foreach (int a in array)
    {
        if (a > max) max = a;
    }
    return max;
}

int minElement(int[] array) //метод возвращает минимальный элемент массива
{
    int min = array[0];
    foreach (int a in array)
    {
        if (a < min) min = a;
    }
    return min;
}

void result(int max, int min)
{
    Console.WriteLine($"Разница между Max ({max}) и Min ({min}) элементами массива равна: {max - min} ");
}

int size = sizeArray();
int[] arr = fillArray(size);

int max = arr.Max(); // либо через метод maxElement
int min = arr.Min(); // либо через метод minElement

Console.WriteLine();

result(max,min);// либо result(maxElement(arr), minElement(arr));
System.Console.WriteLine("======================================");