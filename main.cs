using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];

        Console.WriteLine("Введите 10 чисел:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int bad = -1;

        for (int i = 1; i < 10; i++)
        {
            if (a[i] <= a[i - 1])
            {
                bad = i + 1;
                break;
            }
        }

        if (bad == -1)
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        else
            Console.WriteLine($"Последовательность не упорядочена. Первое нарушение: число {bad} ({a[bad - 1]}).");
    }
}