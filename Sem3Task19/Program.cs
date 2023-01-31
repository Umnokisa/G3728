﻿// Задача №19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// Предлагаем пользователю ввести число
Console.WriteLine("Введите пятизначное число: ");

// Парсируем его
string number = Console.ReadLine()??"0";

// Смотрим, сколько в ведённом числе символов
int s = number.ToString().Length;

// Если смимволов 5, то
if (s == 5)
{
    // Так как цифр всего пять, то мы сравниваем между собой попарно первое и последнее, второе и четвёртое числа массива
    if (number[0] == number[4] && number[1] == number[3])
    {
    // Если всё верно, то это палиндром    
        Console.WriteLine(number + " - это палиндром");
    }
    else
    {
    // Ну или нет
        Console.WriteLine(number + " - это не палиндром");
    }
}
else
{
    Console.WriteLine(number + " - это не пятизначное число");
}