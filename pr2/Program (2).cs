using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int minPositiveNumber = int.MaxValue;

        Console.WriteLine("Введіть 10 чисел:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Число {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;

              
                if (number > 0 && number < minPositiveNumber)
                {
                    minPositiveNumber = number;
                }
            }
            else
            {
                Console.WriteLine("Введено некоректне число. Будь ласка, введіть число ще раз.");
                i--; 
            }
        }

        if (minPositiveNumber == int.MaxValue)
        {
            Console.WriteLine("Серед введених чисел немає додатніх чисел.");
        }
        else
        {
            Console.WriteLine($"Найменше додатнє число: {minPositiveNumber}");
        }
    }
}
