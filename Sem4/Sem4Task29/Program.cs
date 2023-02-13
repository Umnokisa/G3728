// Задача №29.
// Напишите программу, которая задаёт массив из n элементов и выводит их на экран.

// Вводим длину массива
Console.WriteLine("Введите длинну массива: ");
// Парсируем его
string? lenArray = Console.ReadLine()??"0";
int len = int.Parse(lenArray);


int[] randomArray = new int[len];
for (int i = 0; i < randomArray.Length; i++)
{
    //  Рандомные значения в массиве
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


