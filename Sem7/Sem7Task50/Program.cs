// Задача №50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

// Генерируем размер массива.

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];

// Наполняем его случайными числами
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

// Ищем элемент в массиве 
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Ups! Такого элемента не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
