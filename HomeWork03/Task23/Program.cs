//Задача 23
// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//==========================
//
//написать метод, который записывает число из консоли, проверяет на возможность возведения в куб
//написать метод создающий массив и помещащий в этот массив результаты вычислений
//написать метод, выводящий решение на экран

Console.Clear();
int numLen()//метод принимающий длину массива и проверяющие на >1
{
    int numLen = 0;
    while (numLen < 1)
    {
        Console.Write("Введите значение длины массива, оно должно быть больше '1': ");
        numLen = Convert.ToInt32(Console.ReadLine());
    }
    return numLen;
}


int[] expArray(int numLen)//создали метод, который заполняет архив возведенными в куб
{
    int[] exp = new int[numLen];
    for (int i = 0; i < numLen; i++)
    {
        exp[i] = exp[i]*exp[i]*exp[i];
        Console.WriteLine("Вывод инфы о индексе "+exp[i]);
    }
    return exp;
}


void print(int lengthMassive, int[] resMassive)
{
    Console.WriteLine("Таблица кубов от 1 до " + lengthMassive);
    for (int j = 0; j < lengthMassive; j++)
    {
        Console.WriteLine(resMassive[j]);
    }
}



int lengthMassive = numLen();//присвоили переменную длине массива
Console.WriteLine($"Вы ввели значение {lengthMassive}, которое является длиной массива");//вывели надпись длины массива

int[] resMassive = expArray(lengthMassive);//в методе создали массив, произвели рассчеты и передали их массиву resMassive

print(lengthMassive, resMassive);


