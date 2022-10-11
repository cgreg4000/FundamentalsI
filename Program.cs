using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print values from 1-255");
            Console.WriteLine("With \"For\" loop");
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Print values from 1-255");
            Console.WriteLine("With \"While\" loop");
            int j = 1;
            while (j <= 255)
            {
                Console.WriteLine(j);
                j++;
            }


            Console.WriteLine("Print all values from 1-100 that are divisible by 3 or 5, but not both.");
            Console.WriteLine("With \"For\" loop");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Print all values from 1-100 that are divisible by 3 or 5, but not both.");
            Console.WriteLine("With \"While\" loop");
            int k = 1;
            while (k <= 100)
            {
                if (k % 3 == 0 && k % 5 == 0)
                {
                    k++;
                    continue;
                }
                else if (k % 3 == 0 || k % 5 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }

            Console.WriteLine("For values from 1-100, print \"Fizz\" for multiples of 3, \"Buzz\" for multiples of 5, and \"FizzBuzz\" for numbers that are multiples of both 3 and 5");
            Console.WriteLine("With \"For\" loop");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

            Console.WriteLine("For values from 1-100, print \"Fizz\" for multiples of 3, \"Buzz\" for multiples of 5, and \"FizzBuzz\" for numbers that are multiples of both 3 and 5");
            Console.WriteLine("With \"While\" loop");
            int l = 1;
            while (l <= 100)
            {
                if (l % 3 == 0 && l % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (l % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (l % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                l++;
            }
        }
    }
}
