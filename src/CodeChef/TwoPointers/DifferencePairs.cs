namespace CodeChef.TwoPointers;

internal class DifferencePairs
{
    // You could check the full problem at www.codechef.com/practice/course/two-pointers/POINTERF/problems/PREP68?tab=statement

    // Approach 1: Using nested loops
    // Complexity: O(N²)
    private static bool FindDifferencePairsNestedLoops(int maxIndice, int expectedResult, List<int> list)
    {
        list.Sort();

        for (int i = maxIndice - 1; i > 0; i--)
        {
            for (int j = maxIndice - 2; j >= 0; j--)
            {
                if (list[i] - list[j] == expectedResult)
                    return true;
            }
        }

        return false;
    }

    // Approach 2: Using Two-Pointers
    // Complexity: O(N/log N)
    //             log N => sorting
    //             N     => not quadratic time complexity
    private static bool FindDifferencePairsTwoPointers(int maxIndice, int expectedResult, List<int> list)
    {
        list.Sort();

        int i = 0; int j = 0;

        while (i < maxIndice && j < maxIndice)
        {
            int difference = list[i] - list[j];

            if (difference == expectedResult)
                return true;
            else if (difference > expectedResult)
                j++;
            else
                i++;
        }

        return false;
    }

    public static void Execute()
    {
        int testCases = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < testCases; i++)
        {
            string[] inputs = Console.ReadLine().Split(" ");

            int n = Convert.ToInt32(inputs[0]);
            int b = Convert.ToInt32(inputs[1]);

            List<int> list = Console.ReadLine()
                .Split(" ")
                .ToList()
                .Select(element => Convert.ToInt32(element))
                .ToList();

            bool found = FindDifferencePairsNestedLoops(n, b, list);

            if (found)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}
