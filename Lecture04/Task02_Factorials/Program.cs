


// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n* Factorial(n-1);
// }

// for (int i = 0; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i));
// }


int Fibonacchi(int n)
{
    if(n==1||n==2) return 1;
    else return Fibonacchi(n-1)+Fibonacchi(n-2);
}

for (int i=1; i<50; i++)
{
    System.Console.WriteLine($"{i} = {Fibonacchi(i)}");
}