Console.WriteLine("Введите число...");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    
    Console.WriteLine($"Третья цифра числа: {number}");
}
