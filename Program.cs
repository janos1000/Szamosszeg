using System;

class Program
{
    static void Main()
    {
            int positiveSum = 0;
            int negativeSum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Kérem, adjon meg egy egész számot: ");
                int number;

                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Kérlek, érvényes egész számot adj meg!");
                }


                if (number > 0)
                {
                    positiveSum += number;
                }
                else if (number < 0)
                {
                    negativeSum += number;
                }

            }

            Console.WriteLine($"A pozitív számok összeg: {positiveSum}");
            Console.WriteLine($"A negatív számok összeg: {negativeSum}");
        }
    }