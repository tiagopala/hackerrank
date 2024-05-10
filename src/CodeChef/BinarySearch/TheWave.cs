using System.Diagnostics;

namespace CodeChef.BinarySearch;

internal class TheWave
{
    private IEnumerable<long> TheWaveGiantArray { get; set; }

    private IEnumerable<long> TheWaveGiantQuery { get; set; }

    public TheWave()
    {
        TheWaveGiantArray = Constants.TheWaveGiantArray
            .Split(' ')
            .Select(long.Parse);

        TheWaveGiantQuery = Constants.TheWaveGiantQuery
            .Split(' ')
            .Select(long.Parse);
    }

    /* Binary Search Approach */
    private static void CheckSignBinarySearchUsingArrays(long[] arr, long[] queries)
    {
        Array.Sort(arr);

        bool isEven = arr.Length % 2 == 0;

        foreach (long query in queries)
        {
            int index = Array.BinarySearch(arr, query);

            if (index >= 0)
                Console.WriteLine("0 ");
            else
            {
                index = ~index;

                if (isEven)
                {
                    if (index % 2 == 0)
                        Console.Write("POSITIVE ");
                    else
                        Console.Write("NEGATIVE ");
                }   
                else
                {
                    if (index % 2 == 0)
                        Console.Write("NEGATIVE ");
                    else
                        Console.Write("POSITIVE ");
                }
            }
        }
    }

    /* HashSet Approach */
    private static void CheckSignUsingHashSet(long[] arr, long[] queries)
    {
        // Converts the array into a HashSet just to check for the index equals 0, not so performatic...
        HashSet<long> set = new(arr);

        bool isEven = set.Count % 2 == 0;

        foreach (long query in queries)
        {
            if (set.Contains(query))
                Console.Write("0 ");
            else
            {
                int index = Array.BinarySearch(arr, query);
                index = ~index;

                Console.Write(isEven ? (index % 2 == 0 ? "POSITIVE " : "NEGATIVE ") : (index % 2 == 0 ? "NEGATIVE " : "POSITIVE "));
            }
        }
    }

    private static void CheckSignBinarySearchUsingLists(List<long> list, List<long> queries)
    {
        list.Sort();

        bool isEven = list.Count% 2 == 0;

        foreach (long query in queries)
        {
            int index = list.BinarySearch(query);

            if (index >= 0)
                Console.WriteLine("0 ");
            else
            {
                index = ~index;

                if (isEven)
                {
                    if (index % 2 == 0)
                        Console.Write("POSITIVE ");
                    else
                        Console.Write("NEGATIVE ");
                }
                else
                {
                    if (index % 2 == 0)
                        Console.Write("NEGATIVE ");
                    else
                        Console.Write("POSITIVE ");
                }
            }
        }
    }

    public void ExecuteUsingArrays()
    {
        var watch = Stopwatch.StartNew();

        long[] arr = TheWaveGiantArray.ToArray();

        long[] queriesArray = TheWaveGiantQuery.ToArray();

        CheckSignBinarySearchUsingArrays(arr, queriesArray);

        watch.Stop();

        Console.WriteLine($"Finished using binary search algorithm within arrays in {watch.Elapsed}");
    }

    public void ExecuteUsingLists()
    {
        var watch = Stopwatch.StartNew();

        List<long> list = TheWaveGiantArray.ToList();

        List<long> queriesList = TheWaveGiantQuery.ToList();

        CheckSignBinarySearchUsingLists(list, queriesList);

        watch.Stop();

        Console.WriteLine($"Finished using binary search algorithm within lists in {watch.Elapsed}");
    }

    public void ExecuteUsingHashSets()
    {
        var watch = Stopwatch.StartNew();

        long[] arr = TheWaveGiantArray.ToArray();

        long[] queriesArray = TheWaveGiantQuery.ToArray();

        CheckSignUsingHashSet(arr, queriesArray);

        watch.Stop();

        Console.WriteLine($"Finished using hash sets + binary search algorithm within arrays in {watch.Elapsed}");
    }
}
