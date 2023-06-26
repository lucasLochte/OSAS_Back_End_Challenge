using System;
using System.Collections.Generic;
using DividerDecomposer.Services;

namespace DividerDecomposer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo: ");
            int number = int.Parse(Console.ReadLine());

            DivisorService divisorService = new DivisorService();

            List<int> divisors = divisorService.GetDivisors(number);
            PrintVector(divisors, "Divisores: ");
        
            Console.WriteLine();

            List<int> primeDivisors = divisorService.GetPrimeDivisors(number);
            PrintVector(primeDivisors, "Divisores Primos: ");
        
        }

        static void PrintVector(List<int> numbers, string consoleOutput)
        {
            int quantity = numbers.Count;
            int count = 0;

            Console.Write(consoleOutput);
            foreach (int divisor in numbers)
            {
                count++;
                if (count == quantity)
                {
                    Console.Write(divisor);
                }
                else
                {
                    Console.Write(divisor + ", ");
                }

            }
        }
    }
}
