using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int rows;
                int columns;
                string direct;

                Console.Write("Enter the number of rows: ");
                while (!int.TryParse(Console.ReadLine(), out rows))
                {
                    Console.Write("Enter the number: ");
                }

                Console.Write("Enter the number of columns: ");
                while (!int.TryParse(Console.ReadLine(), out columns))
                {
                    Console.Write("Enter the number: ");
                }
                if ((rows <= 0) | (rows > 30) | (columns <= 0) | (columns > 30))
                {
                    Console.Write("Wrong range");
                }
                else
                {
                    Console.Write("Enter the direction: ");
                    direct = Console.ReadLine();
                    if ((direct == "l") ^ (direct == "r"))
                    {
                        string[,] mas = new string[rows, columns];
                        string str = "*";
                        Random rnd = new Random();
                        for (int i = 0; i < rows; i++)
                        {

                            for (int j = 0; j < columns; j++)
                            {

                                if (((direct == "l") & (i == j)) | ((direct == "r") & (j == columns - i - 1)))
                                {
                                    mas[i, j] = str;

                                }
                                else
                                {

                                    mas[i, j] = rnd.Next(10, 99).ToString();

                                }
                                Console.Write($"{mas[i, j]}\t");
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.Write("Wrong symbol!");



                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");

            }
        }
    }
}
