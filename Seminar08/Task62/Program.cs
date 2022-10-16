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
int fill = 0;
int offset = 0;
for (int i = offset; i < spiralArray.GetLength(0) - offset; i++)
{
    for (int j = offset; j < spiralArray.GetLength(1) - offset; j++) //если выйдет за предел массива - удалить равно
    {
        if (spiralArray[i, j] == 0)
        {
            spiralArray[i, j] = fill;
            fill++;
        }
    }
    for (i = offset; i <= spiralArray.GetLength(0) - offset; i++)// 
    {
        int j = spiralArray.GetLength(1) - offset;//
        if (spiralArray[i, j] == 0)
        {
            spiralArray[i, j] = fill;
            fill++;
        }
    }
    for (int j = spiralArray.GetLength(1) - offset; j > offset; j--)
    {
        if (spiralArray[i, j] == 0)
        {
            spiralArray[i, j] = fill;
            fill++;
        }
    }
    offset++;
    for (i = spiralArray.GetLength(0) - offset; i > offset; i--) //spiralArray.GetLength(0) можно уменьшить на 1
    {
        int j = spiralArray.GetLength(1) - offset;
        if (spiralArray[i, j] == 0)
        {
            spiralArray[i, j] = fill;
            fill++;
        }
    }
}

//печать улитки
for (int i = 0; i < spiralArray.GetLength(0); i++)
{
    for (int j = 0; j < spiralArray.GetLength(1); j++)
    {
        Console.Write(spiralArray[i, j] + " ");
    }
    Console.WriteLine();
}
