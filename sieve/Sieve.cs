using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    { if (limit < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(limit), "Limit cannot be negative.");
        }
        List<int> primes = new List<int>();
     int n=limit;
    
        bool[] prime = new bool[n + 1];
        for (int i = 0; i <= n; i++)
        {
            prime[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            // If prime[p] is not changed, then it is a prime
            if (prime[p] == true)
            {
                // Update all multiples of p
                for (int i = p * p; i <= n; i += p)
                {
                    prime[i] = false;
                }
            }
        }

        // Print all prime numbers
        for (int p = 2; p <= n; p++)
        {
            if (prime[p] == true)
            {
                primes.Add(p);
            }
        }

        return primes.ToArray();
            
    
        throw new NotImplementedException("You need to implement this method.");
    }
}