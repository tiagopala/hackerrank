namespace HackerRank.Arrays;

internal class SparseArrays
{
    // You could check the full problem at www.hackerrank.com/challenges/sparse-arrays/problem

    private static List<int> MatchingStrings(List<string> stringList, List<string> queries)
    {
        List<int> results = new();

        for (int i = 0; i < queries.Count; i++)
        {
            int occurrences = 0;

            for (int j = 0; j < stringList.Count; j++)
            {
                if (stringList[j] == (queries[i]))
                    occurrences++;
            }

            results.Add(occurrences);
        }

        return results;
    }

    public static void Execute()
    {
        Console.WriteLine("\n-> Sparse Arrays Exercise");

        List<string> stringList = new()
        {
            "aba",
            "baba",
            "aba",
            "xzxb"
        };

        List<string> queries = new()
        {
            "aba",
            "xzxb",
            "ab"
        };

        List<int> result = MatchingStrings(stringList, queries);

        Console.Write("Occurrences: ");

        foreach(int i in result)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }
}
