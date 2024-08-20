//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143?

using System;

public class Program
{
    public static void Main(string[] args)
    {
        long largestPrimeFactor = LargestPrimeFactor(600851475143);

        Console.WriteLine(largestPrimeFactor);
    }

    public static long LargestPrimeFactor(long number)
    {
        long largestPrimeFactor = 1;

        while (number % 2 == 0)
        {
            number /= 2;
            largestPrimeFactor = 2;
        }

        long oddNumber = 3;

        while (oddNumber <= number)
        {
            if (number % oddNumber == 0) 
            {
                number /= oddNumber;
                largestPrimeFactor = oddNumber;
            }
            else
            {
                oddNumber += 2;
            }
        }
        return largestPrimeFactor;
    }

}