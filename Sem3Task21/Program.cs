// Задача №21 
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X первой точки: ");
// Парсируем его
string? coordx1 = Console.ReadLine()??"0";
int x1 = int.Parse(coordx1);

Console.WriteLine("Введите координату X первой точки: ");
// Парсируем его
string? coordy1 = Console.ReadLine()??"0";
int y1 = int.Parse(coordy1);

Console.WriteLine("Введите координату X первой точки: ");
// Парсируем его
string? coordz1 = Console.ReadLine()??"0";
int z1 = int.Parse(coordz1);

Console.WriteLine("Введите координату X первой точки: ");
// Парсируем его
string? coordx2 = Console.ReadLine()??"0";
int x2 = int.Parse(coordx2);

Console.WriteLine("Введите координату X первой точки: ");
// Парсируем его
string? coordy2 = Console.ReadLine()??"0";
int y2 = int.Parse(coordy2);

Console.WriteLine("Введите координату X первой точки: ");
// Парсируем его
string? coordz2 = Console.ReadLine()??"0";
int z2 = int.Parse(coordz2);

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

// Вычисляем расстояние. Math.Sqrt - функция квадратного корня
double length = Math.Sqrt(A * A + B * B + C * C);

// Выводим результат
Console.WriteLine("Длинна отрезка " + length);
