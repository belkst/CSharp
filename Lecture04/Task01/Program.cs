

void printArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void fillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"Введите поочереди значение ячейки {i},{j} = ");
            matr[i, j] = Convert.ToInt32(Console.ReadLine()); //new Random().Next(1, 10);
        }

    }
}

int[,] matrix = new int[3, 4];


printArray(matrix);
fillArray(matrix);
printArray(matrix);