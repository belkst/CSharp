// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// запросить у пользователя длину массива
// создать массив
// заполнить случайными числами, рандомайзером
// создать метод, суммирующий элементы стоящие на нечетных позициях
// вывести инфо в консоль


Console.Clear();

int sizeMassive()//метод запрашивает и возвращает количество элементов массива, число больше 0
{
    Console.Write("Введите количество элементов массива: ");
    int sizeMass = Convert.ToInt32(Console.ReadLine());
    while (sizeMass < 0)
    {
        Console.WriteLine("Вы ввели неверное значение, пожалуйста, повторите ввод:");
        sizeMass = Convert.ToInt32(Console.ReadLine());
    }

    // Console.WriteLine("Введенное Вами количество элементов массива: " + sizeMass);
    return sizeMass;
}

// int[] createMassive(int size) //метод создает массив, к кол-м эл-в на основании вход параметра
// {
//     int[] array = new int[size];
//     return array;
// }

int[] inRandMassive(int size) //заполняем массив случайными числами
{
    int[] exMassive = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        exMassive[i] = rand.Next(0, 9999);
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Элемент массива {i} = {exMassive[i]}");
            // либо Console.WriteLine($"Элемент массива {i+1} = {exMassive[i]}"); для "правильного" отображения нечетных
            Console.ResetColor();
        }
        else
            Console.WriteLine($"Элемент массива {i} = {exMassive[i]}");
            // либо Console.WriteLine($"Элемент массива {i+1} = {exMassive[i]}"); для "правильного" отображения нечетных
    }
    return exMassive;
}

int sumElement(int[] randArray) // складывает содержимое нечетных элементов массива и возвращает их сумму
{
    int size = randArray.Length;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + randArray[i];
        }
    }
    return sum;
}

int x = sizeMassive();
// System.Console.WriteLine($"X = {x}");

int[] array = inRandMassive(x);
int sum = sumElement(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива на нечетных позициях равна: {sum}\n");
Console.WriteLine("======================================");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Нечетные"); Console.ResetColor(); Console.WriteLine(" позиции в массиве - это позиции с четной индексацией, и наоборот.");
Console.WriteLine("======================================\n");