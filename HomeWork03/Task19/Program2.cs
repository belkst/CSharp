int palNumber = 14212;


int reverseNumber(int palNumber)
{
    
   
    while (tempNum > 10)
    int tempNum = palNumber;
    int revNum = 0;
    {
        revNum = revNum * 10 + tempNum % 10;
        tempNum = tempNum / 10;
    }
    Console.WriteLine(revNum);
    Console.WriteLine(palNumber);
    Console.WriteLine("Должно передать ревнам");
    return revNum;
}

int c = reverseNumber(14241);
Console.WriteLine(c);

