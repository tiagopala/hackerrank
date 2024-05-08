namespace HackerRank.Arrays;

internal class DynamicArray
{
    // You could check the full problem at www.hackerrank.com/challenges/dynamic-array/problem

    private static List<int> QueryDynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> arr = new();

        for (int i = 0; i < n; i++)
        {
            arr.Add(new List<int>());
        };

        List<int> result = new();

        int lastAnswer = 0;

        for (int i = 0; i < queries.Count; i++)
        {
            int x = queries[i][1];
            int y = queries[i][2];
            int idx = ((x ^ lastAnswer) % n);

            if (queries[i][0] == 1)
            {
                arr[idx].Add(y);
            }
            else
            {
                lastAnswer = arr[idx][y % arr[idx].Count];
                result.Add(lastAnswer);
            }
        }

        return result;
    }

    public static void Execute()
    {
        Console.WriteLine("\n-> Dynamic Array Exercise");

        int n = 2;

        List<List<int>> list = new()
        {
            new List<int>{ 1, 0, 5 },
            new List<int>{ 1, 1, 7 },
            new List<int>{ 1, 0, 3 },
            new List<int>{ 2, 1, 0 },
            new List<int>{ 2, 1, 1 },
            new List<int>{ 1, 0, 5 }
        };

        List<int> result = QueryDynamicArray(n, list);

        Console.Write("Result: ");

        foreach (var item in result)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }
}
