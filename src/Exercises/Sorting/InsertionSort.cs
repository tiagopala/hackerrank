namespace Exercises.Sorting;

internal class InsertionSort
{
    // You could check the full problem at www.hackerrank.com/challenges/insertionsort1/problem

    private static void PrintArray(List<int> list)
    {
        for (int j = 0; j < list.Count; j++)
        {
            Console.Write($"{list[j]} ");
        }

        Console.Write("\n");
    }

    private static void Sort(int n, List<int> list)
    {
        int lastValue = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            int initialValue = list[i];

            if (i == 0)
            {
                list[i] = lastValue;
            }
            else
            {
                int previous = list[i - 1];

                if (previous < lastValue)
                {
                    list[i] = lastValue;
                    lastValue = list[i - 1];
                }
                else
                {
                    if (lastValue == 0)
                    {
                        lastValue = list[i];
                    }

                    list[i] = list[i - 1];
                }
            }

            if (initialValue != list[i])
            {
                PrintArray(list);
            }
        }
    }

    public static void Execute()
    {
        Console.WriteLine("\nInserting Sort Part 1 Exercise");

        int n = 5;

        List<int> list = [2, 4, 6, 8, 3];

        Sort(n, list);
    }
}
