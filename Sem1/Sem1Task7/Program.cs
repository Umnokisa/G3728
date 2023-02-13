// Задача №7
// Напишите программу, которая на вход принимает
// трёхзначное число, а на выходе показывает 
// последнюю цифру этого числа

//Считываем данные с консоли 
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputNumLine != null)
{
    // Парсим введенное число
    int imputNumberA = int.Parse(imputNumLine);

    int lastDigit = imputNumberA % 10;

    Console.WriteLine(lastDigit);

}