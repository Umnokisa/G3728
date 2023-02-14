// Задача №52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Генерируем случайный размер массива
Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];

// Наполняем его случайными числами
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(-10, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("А теперь считаем");
Console.WriteLine ("Чисел в каждом столбце: " + arr.GetLength(0) + ". Столбцов: " + arr.GetLength(1));
Console.WriteLine("Среднее арифметическое элементов в каждом столбце (через пробел):");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    sum = sum / arr.GetLength(0);
    Console.Write($"{ sum } ");
}
