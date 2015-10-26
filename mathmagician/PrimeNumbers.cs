using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathmagician
{
    public class PrimeNumbers : NaturalNumbers
    {
        public PrimeNumbers()
        {
            first = 1;
        }

        public override int GetNext(int x)
        {
            bool isNotPrime = true;
            int output = 0;
            x++;
            while(isNotPrime)
            {
                if (isPrime(x))
                {
                    output = x;
                    isNotPrime = false;
                }
                else
                {
                    x++;
                }
            }
            return output;
        }

        private bool isPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
