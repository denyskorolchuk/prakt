using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(0, 11);
        int attempts = 0;
        bool hasGuessed = false;

        Console.WriteLine("Вгадайте число від 0 до 10.");

        while (!hasGuessed)
        {
            Console.Write("Введіть вашу спробу: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                if (guess < 0 || guess > 10)
                {
                    Console.WriteLine("Введіть число від 0 до 10.");
                }
                else
                {
                    attempts++;

                    if (guess == secretNumber)
                    {
                        Console.WriteLine($"Вітаємо! Ви вгадали число {secretNumber} за {attempts} спроб.");

                        Console.Write("Бажаєте продовжити гру? (Так/Ні): ");
                        string playAgain = Console.ReadLine();

                        if (playAgain.ToLower() == "ні")
                        {
                            hasGuessed = true; // Завершуємо гру, якщо користувач не бажає продовжувати
                        }
                        else
                        {
                            secretNumber = random.Next(0, 11);
                            attempts = 0;
                            Console.WriteLine("Нова гра. Вгадайте число від 0 до 10.");
                        }
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Загадане число більше.");
                    }
                    else
                    {
                        Console.WriteLine("Загадане число менше.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Будь ласка, введіть число від 0 до 10.");
            }
        }
    }
}
