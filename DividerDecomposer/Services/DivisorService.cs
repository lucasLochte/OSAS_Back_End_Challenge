using System;
using System.Collections.Generic;

namespace DividerDecomposer.Services
{
    public class DivisorService
    {
        public List<int> GetDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int i=1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }

        public List<int> GetPrimeDivisors(int number)
        {
            List<int> primeDivisors = new List<int>();
            List<int> divisors = GetDivisors(number);

            foreach(int divisor in divisors)
            {
                if (IsPrime(divisor))
                {
                    primeDivisors.Add(divisor);
                }
            }

            return primeDivisors;
        }

        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % 2 == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
