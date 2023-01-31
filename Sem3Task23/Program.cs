// Задача №23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
// Парсируем его
string? n = Console.ReadLine()??"0";
int number = int.Parse(n);

//Выводим результат пользователю
for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}