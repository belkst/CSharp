Console.Write("Cредне-арифметическое заданного массива ровняется - ");
int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
int result = 0;
for (int i = 0; i < numbers.Length; i++) result = result + numbers[i];

Console.WriteLine(result / numbers.Length);