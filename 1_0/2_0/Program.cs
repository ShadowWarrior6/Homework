int max =0;

Console.WriteLine("Ввидите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ввидите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ввидите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber>max)
{
    max=firstNumber;
}

if (secondNumber>max)
{
    max=secondNumber;
}

if (thirdNumber>max)
{
    max= thirdNumber;
}

Console.WriteLine("max = "+ max);

