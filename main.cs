using System;

class Program
{
    static void Main()
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] names = { "января", "февраля", "марта", "апреля", "мая", "июня",
                           "июля", "августа", "сентября", "октября", "ноября", "декабря" };

        try
        {
            Console.Write("Год: ");
            int year = int.Parse(Console.ReadLine());
            bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            if (leap) days[1] = 29;
            int max = leap ? 366 : 365;

            Console.Write($"День (1-{max}): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > max)
                throw new Exception($"Число должно быть от 1 до {max}");

            int m = 0;
            while (n > days[m])
                n -= days[m++];

            Console.WriteLine($"{n} {names[m]}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}