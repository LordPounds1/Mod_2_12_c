using System;

class Program
{
    static void Main()
    {
        Console.Write("c. Введите значение a (a < 50): ");
        int a = int.Parse(Console.ReadLine());

        if (a < 50)
        {
            Console.WriteLine($"Третьи степени всех целых чисел от {a} до 50:");
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
        else
        {
            Console.WriteLine("Значение a должно быть меньше 50.");
        }
    }
}
