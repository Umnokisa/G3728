﻿// Задача №8. 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

        // // Обозначаем начало массива
        //     int i = 1;
        // // Вводим в работу логический тип
        //     bool not = true;

        // //Считываем данные с консоли число
        //     Console.WriteLine("Введите любое положительное число:");
        //     string? Num = Console.ReadLine();

        // //Парсим введенное число
        //     int n = int.Parse(Num);

        //     Console.WriteLine("Чётные числа от 1 до " + n + ":");
            
        // // Проверяем, что введенное число больше единицы на старте массива
        //     while (i < n)
        //     {

        // // Делится ли оно без остатка    
        //         if (i % 2 == 0)
        //         // Входим в цикл с увеличением на 1, пока i 
        //         // не поравняется с введенным числом
        //         {
        //             Console.Write(i + ", ");
        //             not = false;
        //         }
        //         i++;
        //     }

        // // Если ввели единицу
        //     if (not)
        //     {
        //         Console.WriteLine("Чётных чисел нет");
        //     }

// Задача №8. 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Обозначаем начало массива
int i = 2;
// Вводим в работу логический тип
bool not = true;

//Считываем данные с консоли число
Console.WriteLine("Введите любое положительное число:");
string? num = Console.ReadLine()??"0";

//Парсим введенное число
int n = int.Parse(num);

Console.WriteLine("Чётные числа от 1 до " + n + ":"); 

// Проверяем, что введенное число больше единицы на старте массива
while (i < n)
{

    Console.Write(i + ", ");
    not = false;

    i = i + 2;
}

// Если ввели единицу
if (not)
{
    Console.WriteLine("Чётных чисел нет");
}