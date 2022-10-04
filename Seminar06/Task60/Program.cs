//  { 1, 9, 9, 0, 2, 8, 0, 9 }
// частотный массив может быть представлен так:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// создаем и заполняем массив
// 
// 

int[] array = { 1, 9, 9, 0, 2, 8, 0, 9 };

int CountNum(int[] col, int number)
{
    int count = 0;
    int len = col.Length;
    for (int i = 0; i < len; i++)
    {
        if (col[i] == number)
        {
            count++;
        }
    }
    return count;
}

int size = array.Length;
for (int i = 0; i < size; i++)
{
Console.WriteLine($"{array[i]} встречается {CountNum(array, array[i])} раз");
}
