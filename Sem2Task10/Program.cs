// Задача №10
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");

string? number = Console.ReadLine()??"0";
int num = int.Parse(number);
int s = num.ToString().Length;

if (s < 3 || s > 3)
{
   Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
int res = ((num / 10) % 10);
Console.WriteLine(res); 
}