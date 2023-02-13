//Задача 25
// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

// Вводим число
Console.WriteLine("Введите число: ");
// Парсируем его
string? number1 = Console.ReadLine()??"0";
int n1 = int.Parse(number1);

// Вводим степень
Console.WriteLine("Введите степень, в которую мы это число возводим: ");
// Парсируем 
string? number2 = Console.ReadLine()??"0";
int n2 = int.Parse(number2);
ToDegree(n1, n2);


// Возводим в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}


