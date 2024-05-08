namespace CodeChef.BinarySearch;

internal class CoinsAndTriangle
{
    // You could check the full problem at www.codechef.com/practice/course/binary-search/INTBINS01/problems/TRICOIN?tab=statement

    private static int GetMaximumHeightFormula(int numberOfCoins)
    {
        int height = 1;

        while ((height * (height + 1) / 2) <= numberOfCoins)
        {
            height++;
        }

        return height - 1;
    }

    // Time Complexity: O(N) where N is the numberOfCoins, making the complex linear.
    private static int GetMaximumHeightLinear(int numberOfCoins)
    {
        int rows = 0;

        int previousRowCoins = 0;

        int remainingCoins = numberOfCoins;

        for (int i = 0; i < numberOfCoins; i++)
        {
            if (rows == 0)
            {
                rows++;
                remainingCoins--;
                previousRowCoins = 1;
            }
            else
            {
                if (remainingCoins > previousRowCoins)
                {
                    rows++;
                    remainingCoins -= (previousRowCoins + 1);
                    previousRowCoins += 1;
                }
                else
                    break;
            }
        }

        return rows;
    }

    public static void Execute()
    {
        int testCases = 1;

        for (int i = 0; i < testCases; i++)
        {
            int numberOfCoins = 3;

            int result = GetMaximumHeightFormula(numberOfCoins);

            Console.WriteLine(result);
        }
    }
}
