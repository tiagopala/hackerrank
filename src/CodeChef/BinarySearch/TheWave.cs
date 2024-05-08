namespace CodeChef.BinarySearch;

internal class TheWave
{
    private static void PrintSign(List<int> list, int query)
    {
        int result = 1;

        foreach (int item in list)
        {
            result *= (query - item);
        }

        if (result > 0)
        {
            Console.WriteLine("POSITIVE");
            return;
        }

        if (result == 0)
        {
            Console.WriteLine("0");
            return;
        }

        Console.WriteLine("NEGATIVE");
    }

    public static void Execute()
    {
        string[] firstLineInput = "4 6".Split(" ");

        int queries = Convert.ToInt32(firstLineInput[1]);

        List<int> list =
            "1 3 5 100"
            .Split(" ")
            .ToList()
            .Select(x => Convert.ToInt32(x))
            .ToList();

        /*
         * -2 2 4 80 107 5
         */

        for (int i = 0; i < queries; i++)
        {
            int query = Convert.ToInt32(Console.ReadLine());

            PrintSign(list, query);
        }
    }
}
