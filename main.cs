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

        try
        {
            Console.Write("Введите номер дня в году (1-365): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 365)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(n), n, "Число должно быть от 1 до 365");
            }

            int month = 0;
            while (n > daysInMonth[month])
            {
                n -= daysInMonth[month];
                month++;
            }

            Console.WriteLine($"{n} {monthNames[month]}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено не целое число");
        }
    }
}