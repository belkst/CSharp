//3адача №3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Read number, please: ");
int N = Convert.ToInt32(Console.ReadLine());  // Ввод числа

    if(N % 2 == 0) Console.Write( "ДА");
    else Console.Write("НЕТ");

Console.Write("."+ "\n"); //точка и новая строка
