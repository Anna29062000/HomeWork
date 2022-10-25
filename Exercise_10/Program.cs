Console.WriteLine("Введите трезначное число...");
int number = Convert.ToInt32(Console.ReadLine());
number = (number / 10) % 10;
Console.WriteLine($"Вторая цифра числа: {number}");