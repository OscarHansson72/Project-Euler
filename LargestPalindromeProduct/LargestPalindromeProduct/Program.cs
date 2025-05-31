int x = 999;
int y = 999;
int largestPalindrome = 0;

while (x >= 0)
{
    y = x;
    bool found = false;
    while (y >= 0 && !found)
    {
        if(x*y < largestPalindrome)
        {
            found = true;
        }
        else
        {
            int product = x * y;
            if (isPalindrome(product))
            {
                if (product > largestPalindrome)
                {
                    largestPalindrome = product;
                }
            }
            y--;
        }
    }
    x--;
}

Console.WriteLine($"Largest palindrome made from the product of two 3-digit numbers is: {largestPalindrome}");



bool isPalindrome(int number)
{
    if (number < 0) return false;

    int original = number;
    int reversed = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversed = reversed * 10 + digit;
        number /= 10;
    }

    return original == reversed;
}
