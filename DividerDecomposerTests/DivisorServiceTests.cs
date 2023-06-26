using DividerDecomposer.Services;
using System.Collections.Generic;
using Xunit;

namespace DividerDecomposerTests
{
    public class DivisorServiceTests
    {
        private DivisorService divisorService;

        public DivisorServiceTests()
        {
            divisorService = new DivisorService();
        }

        [Fact]
        public void GetDivisors_ReturnsCorrectDivisors()
        {
            int number = 14;
            List<int> expectedDivisors = new List<int> { 1, 2, 7, 14 };

            List<int> divisors = divisorService.GetDivisors(number);

            Assert.Equal(expectedDivisors, divisors);
        }

        [Fact]
        public void GetPrimeDivisors_ReturnsCorrectPrimeDivisors()
        {
            int number = 14;
            List<int> expectedPrimeDivisors = new List<int> { 2, 7 };

            List<int> primes = divisorService.GetPrimeDivisors(number);

            Assert.Equal(expectedPrimeDivisors, primes);
        }

        [Fact]
        public void IsPrime_ReturnsTrueForPrimeNumbers()
        {
            int primeNumber = 7;

            bool isPrime = divisorService.IsPrime(primeNumber);

            Assert.True(isPrime);
        }

        [Fact]
        public void IsPrime_ReturnsFalseForNonPrimeNumbers()
        {
            int nonPrimeNumber = 4;

            bool isPrime = divisorService.IsPrime(nonPrimeNumber);

            Assert.False(isPrime);
        }
    }
}
