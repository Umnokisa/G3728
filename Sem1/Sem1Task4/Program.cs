﻿// Задача №4
// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

 Console.WriteLine("Введите 3 числа:");

//Считываем данные с консоли 1 число
string? Num1 = Console.ReadLine();

//Считываем данные с консоли 2 число
string? Num2 = Console.ReadLine();

//Считываем данные с консоли 3 число
string? Num3 = Console.ReadLine();

//Парсим введенные числа
int n_1 = int.Parse(Num1);
int n_2 = int.Parse(Num2);
int n_3 = int.Parse(Num3);

// Считаем первое число по умолчанию самым большим
int max = n_1;

// Начинаем сравнения чисел. Если 2е число болльше, то оно становится максимальным
if (n_2 > max)
    {
    max = n_2;
    }
// Если 3е число больше установленного максимального, то максимальным становится оно
if (n_3 > max)
{
max = n_3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);