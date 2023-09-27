using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        int sumDiagonal = 0;

        Console.WriteLine("Введіть значення елементів матриці 3x3:");

     
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    matrix[i, j] = element;

                   
                    if (i == j)
                    {
                        sumDiagonal += element;
                    }
                }
                else
                {
                    Console.WriteLine("Введено некоректне число. Будь ласка, введіть число ще раз.");
                    j--; 
                }
            }
        }

       
        Console.WriteLine("Введена матриця:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Сума елементів головної діагоналі: {sumDiagonal}");
    }
}
