using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите номер карты k (6..14): ");
            int k = int.Parse(Console.ReadLine());

            if (k < 6 || k > 14)
                throw new ArgumentOutOfRangeException(nameof(k), "Номер карты должен быть от 6 до 14");

            string name;
            switch (k)
            {
                case 6:  name = "шестёрка"; break;
                case 7:  name = "семёрка";  break;
                case 8:  name = "восьмёрка"; break;
                case 9:  name = "девятка";  break;
                case 10: name = "десятка";  break;
                case 11: name = "валет";    break;
                case 12: name = "дама";     break;
                case 13: name = "король";   break;
                case 14: name = "туз";      break;
                default: name = "неизвестно"; break;
            }

            Console.WriteLine($"Достоинство карты: {name}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено не число");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число слишком большое");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Ошибка: номер карты должен быть от 6 до 14");
        }
        finally
        {
            Console.WriteLine("Работа программы завершена");
        }
    }
}
