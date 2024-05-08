namespace CodeChef.TwoPointers;

internal class TheGreatRun
{
    // You could check the full problem at www.codechef.com/practice/course/two-pointers/POINTERF/problems/PROC18A?tab=solution

    private static int GetMaxUsingTwoPoints(int maxDistance, List<int> list)
    {
        int currentImpressed = 0;

        for (int i = 0; i < maxDistance; i++)
        {
            currentImpressed += list[i];
        }

        int maxImpressed = currentImpressed;

        for (int i = maxDistance; i < list.Count; i++)
        {
            currentImpressed = currentImpressed - list[i - maxDistance] + list[i];
            maxImpressed = Math.Max(maxImpressed, currentImpressed);
        }

        return maxImpressed;
    }

    private static int GetMaxUsingNestedLoops(int maxDistance, List<int> list)
    {
        int maxGirls = 0;

        for (int i = 0; i <= (list.Count() - maxDistance); i++)
        {
            int girls = 0;

            for (int j = 0; j < maxDistance; j++)
            {
                girls += list[i + j];
            }

            if (girls > maxGirls)
                maxGirls = girls;
        }


        return maxGirls;
    }

    public static void Execute()
    {
        int testCases = 1;

        for (int i = 0; i < testCases; i++)
        {
            string[] firstInput = "7 2".Split(" ");

            int N = Convert.ToInt32(firstInput[0]);
            int K = Convert.ToInt32(firstInput[1]);

            List<int> list = "2 4 8 1 2 1 8"
                .Split(" ")
                .ToList()
                .Select(x => Convert.ToInt32(x))
                .ToList();

            int result = GetMaxUsingTwoPoints(K, list);

            Console.WriteLine(result);
        }
    }
}
