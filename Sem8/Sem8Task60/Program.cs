// Задача №60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int dim1 = ReadData("Введите колличество строк: ");
int dim2 = ReadData("Введите колличество столбцов: ");
int dim3 = ReadData("Введите длинну: ");

//Выводим на экран
Console.WriteLine("Сгенерированная матрица: ");
int[,,] array3Dform = CreateNonRepeating3DArray(dim1, dim2, dim3);
Print3DArray(array3Dform);

// Метода генерации двумерного случайного массива
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерируем трехмерный массив 
int[,,] CreateNonRepeating3DArray(int dim1, int dim2, int dim3)
{
int[,,] array = new int[dim1, dim2, dim3];
Random random = new Random();
HashSet<int> usedValues = new HashSet<int>(); // хеш для хранения уже использованных данных

for (int i = 0; i < dim1; i++)
{
    for (int j = 0; j < dim2; j++)
    {
        for (int k = 0; k < dim3; k++)
        {
            int value;
            do
            {
                value = random.Next(10, 99);
            } while (usedValues.Contains(value));
            array[i, j, k] = value;
            usedValues.Add(value);
        }
    }
}

    return array;
}

// Выводим на экран трехмерный массив
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k].ToString("00") + "(" + i + "." + j + "." + k + ") ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

