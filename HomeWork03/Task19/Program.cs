internal class Program
{
    private const string Value = "Палиндром не может состоять из однозначного или отрицательного числа, введите минимум двузначное положительное число";
    private const string Value1 = "Напишите число, которое мы будем проверять по палиндром: ";

    private static void Main(string[] args)
    {
        Console.Clear();
                    
            Console.Write(Value1);
            int palNumber = 0;
            palNumber = Convert.ToInt32(Console.ReadLine());  // Ввод числа
            
            while (palNumber <= 9)
            {
                Console.WriteLine(Value);
                Console.WriteLine();
                Console.Write(Value1);
                palNumber = Convert.ToInt32(Console.ReadLine());  // Ввод числа
            }
        
        int reverseNumber(int x) //создаем метод, разворачивающий число, х - принимаемое из вне значение
        {
            int revNum = 0; //задаем переменную для развернутого числа
            while (x > 0)   // цикл с логикой переворачивания, пока х не достигнет 0 он будет выполняться
            {
                revNum = revNum * 10 + x % 10;
                x = x / 10;
            }
            return revNum; // возвращаем перевернутое личсло
        }

        void compareNumbers(int palNumber, int revNum) //проверяем на палиндром
        {
            if (palNumber == revNum)
            {
                Console.WriteLine("Данное число является палиндромом!");
                Console.WriteLine();
            }
            else Console.WriteLine("Данное число НЕ является палиндромом!");
            Console.WriteLine();
        }


        Console.WriteLine("Исходное число:     " + palNumber); // выводим в консоль исходное число
        // Console.WriteLine("Перевернутое число: " + reverseNumber(palNumber)); // выводим в консоль перевернутое число


        compareNumbers(palNumber, reverseNumber(palNumber)); //выводим в консоль результат сравнения
    }
}