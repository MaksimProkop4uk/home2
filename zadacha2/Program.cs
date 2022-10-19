Console.WriteLine("На выходе показывает третье число");
Console.WriteLine("Введите число: ");
int numA = int.Parse(Console.ReadLine()!);
int thirdDigit(int numA)
{
    if (numA < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (numA >= 1000)
        {
            numA  /= 10;

        }
       numA %= 10;

    }
    return numA;
   } 
Console.WriteLine("Третья цифра числа:" + thirdDigit(numA));