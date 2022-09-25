// Запросить координаты точки 1
// Запросить соординату точки 2
// поместить полученные данные в соответствующие массивы
// произвести вычисления
// вывести расстояние между точками

int[] coordinate(int point) // вводим координаты точки + указываем номер точки point для ввода координат
{
    int[] coordinate = new int[3]; // задаем длину массива
    for (int i = 0; i < coordinate.Length; i++) // цикл заполняющий массив
    {
        Console.Write("Введите значение координаты точки №"+ point + ": ");
        coordinate[i] = Convert.ToInt32(Console.ReadLine());
    }
    return coordinate; // возвращаем массив с тремя координатами точки 
}

double distance(int[] array1, int[] array2) //отправляем два массива, получаем distance - расстояние между точками
{
    int[] stepen = new int[3];
    for (int i = 0; i < 3; i++)
    {
        stepen[i] = array2[i] - array1[i];
        stepen[i] = stepen[i] * stepen[i];
    }

    double distResult = Math.Sqrt(stepen[0] + stepen[1] + stepen[2]);
    return  distResult;
}

void print(double distance)
{
    Console.WriteLine("\nРасстояние между точками составляет: "+distance);
}


int[] a = coordinate(1);//запустил метод для ввода координат первой точки
System.Console.WriteLine();
int[] b = coordinate(2);//запустил метод для ввода координат второй точки

double disRes = distance(a, b);//присвоил переменной disRes расчеты расстояния из метода distance
print(Convert.ToInt16(disRes));//использовал метод print для вывода результата, а также конвертировал, чтобы получать округленное до целых значение расстояния