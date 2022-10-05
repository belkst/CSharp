// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// запросить у пользователя количество вводимых чисел
// ввести числа поочереди через консоль
// добавить логику, которая кладет в переменную - счетчик все числа больше 0


Console.Clear();

int sizeArray()//метод запрашивает и возвращает количество элементов массива, число больше 0
{
    Console.Write("Введите количество М чисел: ");
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

int size = sizeArray(); 

int sum = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-e число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) sum = sum + 1;
}

Console.WriteLine($"Количество числел больше нуля = {sum}");
System.Console.WriteLine();
