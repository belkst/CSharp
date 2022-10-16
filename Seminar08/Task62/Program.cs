/*
Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7

- создать массив [4,4]
- дойти до края массива по строке (GetLength(1))
- дойти до края массива по столбцу (GetLength(0))
- дойти до края массива по строке в обратную сторону 
- дойти до края массива по столбцу в обратную сторону 
кождый шаг вперед необходимо проверять ==0 тогда можно записывать
*/

int[,] spiralArray = new int[4, 4];
int fill = 1;
// int offset = 0;//вместо i- оффсет. да и оффсет <= GetLength(0)/2
for (int offset = 0; offset <= spiralArray.GetLength(0)/2; offset++)//тут?
{
    for (int j = offset; j < spiralArray.GetLength(1) - offset; j++) //вот тут прошел все элементы первой строки
    {
        int i = offset;//нам с первой строки надо начинать потому что
        if (spiralArray[i, j] == 0)
        {
            spiralArray[i, j] = fill;
            fill++;
        }
    }
    for (int i = offset+1; i < spiralArray.GetLength(0) - offset; i++)
    {
        int j = spiralArray.GetLength(1) - offset-1;// лучше не i менять, а в самом элементе
        if (spiralArray[i, j] == 0)
        {
            spiralArray[i, j] = fill;
            fill++;
        }
    }
    for (int j = spiralArray.GetLength(1) - offset-1; j >= offset; j--)
    {
       
        if (spiralArray[spiralArray.GetLength(1) - offset -1, j] == 0)//вот тут вообще
        
        {
            spiralArray[spiralArray.GetLength(1) - offset -1, j] = fill;// и тут
            fill++;
        }
    } 
    for (int i = spiralArray.GetLength(0) - offset-1; i > offset; i--)
    {
        //int j = spiralArray.GetLength(1) - offset-1; //и тут тоже так же?

        if (spiralArray[i, offset] == 0)// выше о убрать)
        {
            spiralArray[i, offset] = fill; 
            fill++;
        }
    }
}

//печать улитки
for (int i = 0; i < spiralArray.GetLength(0); i++)
{
    for (int j = 0; j < spiralArray.GetLength(1); j++)
    {
        Console.Write(spiralArray[i, j] + "  ");
    }
    Console.WriteLine();
}
