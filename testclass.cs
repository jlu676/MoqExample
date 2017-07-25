using Xunit;
using System;

namespace MoqExample
{
    public class testclass
    {
        public void NumberCheck(string number)
        {
            Assert.True(IsNumeric(number));
        }

        public void PrimeCheck(long number)
        {
            Assert.True(IsPrimeNumber(number));
        }

        private bool IsNumeric(string number)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsPrimeNumber(long n)
        {
            // Corner cases
            if (n <= 1) return false;
            if (n <= 3) return true;

            // This is checked so that we can skip 
            // middle five numbers in below loop
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

    }
}