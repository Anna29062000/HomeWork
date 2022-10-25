Console.WriteLine("Введите цифру, обозначающую день недели...");
int number = Convert.ToInt32(Console.ReadLine());
if ((number < 1) | (number > 7))
{
    Console.WriteLine("Вы ввели цифру, которая не соответсвует дню недели");
}
else 
{
    if (number < 6) Console.WriteLine("Не является выходным днем");
    if (number > 5) Console.WriteLine("Является выходным днем");
}