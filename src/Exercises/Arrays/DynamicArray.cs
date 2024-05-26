namespace Exercises.Arrays;

internal class DynamicArray
{
    // You could check the full problem at www.hackerrank.com/challenges/dynamic-array/problem

    private static List<int> QueryDynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> list = [];

        for (int i = 0; i < n; i++)
        {
            list.Add([]);
        };

        List<int> result = new();

        int lastAnswer = 0;

        for (int i = 0; i < queries.Count; i++)
        {
            int x = queries[i][1];
            int y = queries[i][2];
            int idx = (x ^ lastAnswer) % n;

            if (queries[i][0] == 1)
            {
                list[idx].Add(y);
            }
            else
            {
                lastAnswer = list[idx][y % list[idx].Count];
                result.Add(lastAnswer);
            }
        }

        return result;
    }

    public static void Execute()
    {
        Console.WriteLine("\n-> Dynamic Array Exercise");

        int n = 2;

        List<List<int>> list =
        [
            [1, 0, 5],
            [1, 1, 7],
            [1, 0, 3],
            [2, 1, 0],
            [2, 1, 1],
            [1, 0, 5]
        ];

        List<int> result = QueryDynamicArray(n, list);

        Console.Write("Result: ");

        foreach (var item in result)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }
}
