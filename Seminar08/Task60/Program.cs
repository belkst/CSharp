/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

- сформировать одномерный массив 10-99 (заполнение прибавлением 1)
- создать трехмерный массив, заполнить его данными из одномерного массива
- распечатать массив построчно: значение элемента (адрес)

*/

int[] CreateLineArray() //create and fill new one-line array
{
    int[] lineArray = new int[90];
    int num = 9;
    for (int i = 0; i < lineArray.Length; i++)
    {
        lineArray[i] = num + 1;
        num = num + 1;
        // Console.WriteLine(lineArray[i]);
    }
    return lineArray;
}

int[,,] Create3DArray(int[] lineArray) //create and fill, return 3D-array from a one-line array
{
    int[,,] create3DArray = new int[2, 2, 2];
    int[] tempArray = lineArray;
    int temp = 0;
    for (int i = 0; i < create3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < create3DArray.GetLength(1); j++)
        {
            for (int k = 0; k < create3DArray.GetLength(2); k++)
            {
                create3DArray[i, j, k] = tempArray[temp];
                temp = temp + 1;
            }
        }
    }
    return create3DArray;
}

void Print3dArray(int[,,] array3D) //print 3d array
{
    int[,,] printArray = array3D;
    for (int k = 0; k < printArray.GetLength(0); k++)
    {
        for (int i = 0; i < printArray.GetLength(1); i++)
        {
            for (int j = 0; j < printArray.GetLength(2); j++)
            {
                Console.Write($"{printArray[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Print3dArray(Create3DArray(CreateLineArray()));