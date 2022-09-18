// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Read number, please: ");
int N = Convert.ToInt32(Console.ReadLine());  // Ввод числа
int i=2;                                       // Инициализация переменной

while (i<=N)
{
    if(i % 2 == 0) Console.Write(i + ", ");
    i ++;
}
Console.Write("\b"+"\b"); //удалил пробел и последнюю запятую
Console.Write("."+ "\n"); //точка и новая строка
