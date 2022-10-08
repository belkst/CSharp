// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Принять значения переменных 
// проверить прямые на параллельность
// проверка на координаты, лежащие на одной прямой
// произвести расчеты по формуле
// вывести результат


Console.Clear();
Console.WriteLine("Программа вычисления точки пересечения прямых, заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine("");


Console.Write("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


if (k1 == k2 && b1 == b2) //проверяем на вторая прямая есть одна прямая
{
    Console.WriteLine("Обе прямые есть одна прямая");
}
else if (k1 == k2 || b1 == b2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются"); //проверяем на параллельность
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых: ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}

