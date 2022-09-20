int[] array = { 1, 12, 23, 34, 54, 65, 47, 4, 68, 78, 4, 98, 8 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}