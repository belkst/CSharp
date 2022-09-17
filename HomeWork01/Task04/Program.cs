// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Read number, please: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= N; i++) {
    if(i % 2 == 0) {
        Console.Write(i);
        if (i < N - 1) Console.Write(", ");
        if (i >= N - 1) Console.Write(".\n");
    }
}