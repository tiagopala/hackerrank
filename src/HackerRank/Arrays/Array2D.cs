namespace HackerRank.Arrays;

internal class Array2D
{
    // You could check the full problem at www.hackerrank.com/challenges/2d-array/problem

    private static void PrintInput(List<List<int>> arr)
    {
        foreach (var array in arr)
        {
            foreach (var item in array)
                Console.Write($"{item} ");

            Console.Write("\n");
        }
    }

    private static int HourglassSum(List<List<int>> list2D)
    {
        int? greatestSum = null;

        for (int i = 0; i <= 3; i++) // coluna
        {
            for (int j = 0; j <= 3; j++) // linha
            {
                int currentSum = 0;

                int sumFirstLine = list2D[i][j] + list2D[i][j + 1] + list2D[i][j + 2];
                int sumSecondLine = list2D[i + 1][j + 1];
                int sumThirdLine = list2D[i + 2][j] + list2D[i + 2][j + 1] + list2D[i + 2][j + 2];

                currentSum += sumFirstLine + sumSecondLine + sumThirdLine;

                if (greatestSum is null)
                    greatestSum = currentSum;

                if (currentSum > greatestSum)
                    greatestSum = currentSum;
            }
        }

        return (int)greatestSum;
    }

    public static void Execute()
    {
        Console.WriteLine("\n\n-> Array 2D Exercise");

        List<List<int>> list2D = new() 
        {
            new List<int> { 1, 1, 1, 0, 0, 0 },
            new List<int> { 0, 1, 0, 0, 0, 0 },
            new List<int> { 1, 1, 1, 0, 0, 0 },
            new List<int> { 0, 0, 2, 4, 4, 0 },
            new List<int> { 0, 0, 0, 2, 0, 0 },
            new List<int> { 0, 0, 1, 2, 4, 0 }
        };

        /* negative 2D list to for tests:
        List<List<int>> negativeList2D = new()
        {
            new List<int> { -1, -1,  0, -9, -2, -2},
            new List<int> { -2, -1, -6, -8, -2, -5},
            new List<int> { -1, -1, -1, -2, -3, -4},
            new List<int> { -1, -9, -2, -4, -4, -5},
            new List<int> { -7, -3, -3, -2, -9, -9},
            new List<int> { -1, -3, -1, -2, -4, -5 },
        };
        */

        PrintInput(list2D);

        var greatestHourglassSum = HourglassSum(list2D);

        Console.WriteLine($"Greatest hourglass sum: {greatestHourglassSum}");
    }
}
