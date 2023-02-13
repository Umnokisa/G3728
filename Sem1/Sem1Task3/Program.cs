// Задача №3

// Вводим данные с конслои
string? imputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputLine!=null)
{
   // Вариант 1
   // Создаём массив с днями недели
        // string[] DayOfWeek = new string[7];
        // DayOfWeek[0] = "Понедельник";
        // DayOfWeek[1] = "Вторник";
        // DayOfWeek[2] = "Среда";
        // DayOfWeek[3] = "Четверг";
        // DayOfWeek[4] = "Пятница";
        // DayOfWeek[5] = "Суббота";
        // DayOfWeek[6] = "Воскресенье";
    // Парсим введённое число
        // int imputNumber = int.Parse(imputLine);
    // Находим название дня недели по введённому номеру
        // string OutDayOfWeek = DayOfWeek[imputNumber-1];
    // Выводим данные в консоль
        // Console.WriteLine(OutDayOfWeek);

    // Вариант 2
        // int imputNumber = int.Parse(imputLine);
        // string OutDayOfWeek = string.Empty;
        // switch (imputNumber)
        // {
        //     case 1: OutDayOfWeek = "Понедельник"; break;
        //     case 2: OutDayOfWeek = "Вторник"; break;
        //     case 3: OutDayOfWeek = "Среда"; break;
        //     case 4: OutDayOfWeek = "Четверг"; break;
        //     case 5: OutDayOfWeek = "Пятница"; break;
        //     case 6: OutDayOfWeek = "Суббота"; break;
        //     case 7: OutDayOfWeek = "Воскресенье"; break;
        //     default: OutDayOfWeek = "Это не день недели!"; break;
        // }
        // // Выводим данные в консоль
        // Console.WriteLine(OutDayOfWeek);
    
    // Вариант 3
      int imputNumber = int.Parse(imputLine);
      string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNumber));
    Console.WriteLine(outDayOfWeek);
}

