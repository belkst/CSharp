int numDay = -4;

if (numDay == 6 || numDay == 7) Console.WriteLine("Выбранный день - " + numDay + " является выходным днем");
else
{
    if (numDay > 0 & numDay < 6) Console.WriteLine("Этот день - " + numDay + " является будним!");
    else Console.WriteLine("Это число - " + numDay + " не является числом, указывающим на день недели!");
}

