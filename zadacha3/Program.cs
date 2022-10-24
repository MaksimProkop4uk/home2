Console.WriteLine("Введите день недели: ");
int day = int.Parse(Console.ReadLine()!);
void weekend(int day)
{
    if (day > 7 || day < 1) 
    {
        Console.WriteLine("Пожалуйста, введите корректный день недели");
    }
    else if (day == 6 || day == 7)
    {
        Console.WriteLine("Да, это выходной");
    }
    else
    { 
        Console.WriteLine("Нет, это не выходной");
        
    }
    
}
weekend(day);