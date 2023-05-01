// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine());
int number2 = number/10;
System.Console.WriteLine($"Вторая цифра числа {number} - {number2%10}");