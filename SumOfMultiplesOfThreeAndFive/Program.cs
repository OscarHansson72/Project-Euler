//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.

using System;

public class SumOfMultiplesOfThreeAndFive
{
    public static void Main(string[] args)
    {
        int sum = Solution(1000);

        Console.WriteLine(sum);
    }

    //the complexity of this method should be somewhere around O(N/3)
    public static int Solution(int max)
    {
        int sum = 0;

        for (int i = 0, j = 0; i < max; i += 3, j += 5)
        {
            if (max > j && (j % 3) != 0)
            {
                sum += i + j;
            }
            else
            {
                sum += i;
            }
        }

        return sum;
    }
}