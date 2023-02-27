// Задача №58.
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Просим пользователя определить размерность матриц
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int size = InputInt("Размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];



// Генерируем состав матриц. Они будут состоять из чисел от 1 до 9
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9); 
        }
    }
}

// Заполянем шаблоны
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Выводим матрицы на экран
Console.WriteLine("Первая матрица");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение первой и второй матрицы");
PrintArray(matrixC);

// Находим произведения матриц
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
