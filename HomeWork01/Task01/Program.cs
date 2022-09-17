// Задача №1: Выдаем максимальные значения из двух чисел
int a = 3;
int b = 9;
int max = 0;
Console.WriteLine("значение a= " +a);
Console.WriteLine("значение b= " +b);

if (a<b) max = b;
else max = a;

Console.Write("Maксимальное значение: ");
Console.WriteLine(max);