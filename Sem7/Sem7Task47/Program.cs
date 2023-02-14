// Задача №47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

// Используем тип double для вещественных чисел
double[,] numbers = new double[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

// Генерурем массив
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
    }
}

// Выводим полученный массив на экран
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
                Console.WriteLine("");
    }
}