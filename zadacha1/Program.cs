Console.WriteLine("Введите число");
int numA = int.Parse(Console.ReadLine()!);
int secondDigit(int numA)
{
 int a = numA / 10 % 10;
    return a;
}
Console.WriteLine("Второе число: " + secondDigit(numA));