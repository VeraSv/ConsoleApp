using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число строк: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число столбцов: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int[num1, num2];
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Random rnd = new Random();

                    mas[i,j] = rnd.Next(10, 99);
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
