int num = -101; 
Console.WriteLine("В этом числе мы будем искать третью цифру (если она есть): " + num);
num = Math.Abs(num);
if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine("А вот и третья цифра: " +num);
}

else Console.WriteLine("В данном числе нет третьей цифры! программа завершена.");

