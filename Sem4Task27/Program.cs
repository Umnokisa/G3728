// Задача №27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

  

    int num, sum = 0, m;
    //Считываем данные с консоли число
    Console.WriteLine("Введите любое положительное число: ");
    num = int.Parse(Console.ReadLine());  

    while (num>0)
        
        {
            m = num % 10;
            sum = sum + m;
            num = num / 10;
        }

    Console.WriteLine("Сумма всех чисел введённого числа: " + sum);
   