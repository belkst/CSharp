// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 44;
int b = 5;
int c = 78;
int max = a;

if(max<b) max = b;
if(max<c) max = c;

Console.WriteLine("значение a= " +a);
Console.WriteLine("значение b= " +b);
Console.WriteLine("значение c= " +c);
Console.Write("Из них максимальное значение = ");
Console.WriteLine(max);