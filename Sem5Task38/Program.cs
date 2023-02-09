// Задача №38.
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());

// Используем тип double для вещественных чисел
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

// Генерурем массив
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

// Выводим полученный массив на экран
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

// Ищем максимальный и минимальный значения массива
for (int i = 0;  i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

// Выводим максмиальное и минимальное значение
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");

// Вычисляем разницу между максимальным и минимальным значениями элементами массива
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

