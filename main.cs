using System;

class Program
{
    static void Main()
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] monthNames =
        {
            "января", "февраля", "марта", "апреля", "мая", "июня",
            "июля", "августа", "сентября", "октября", "ноября", "декабря"
        };

        Console.Write("Введите номер дня в году (1-365): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 365)
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до 365");
            return;
        }

        int month = 0;
        while (n > daysInMonth[month])
        {
            n -= daysInMonth[month];
            month++;
        }

        Console.WriteLine($"{n} {monthNames[month]}");
    }
}