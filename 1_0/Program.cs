﻿int max = 0;
int min = 0;

Console.WriteLine("Ввидите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ввидите Второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}

Console.WriteLine("max =" + max + " и " + "min =" + min);