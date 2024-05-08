namespace HackerRank.Arrays;

internal class ReverseArrayProblem
{
    // You could check the full problem at www.hackerrank.com/challenges/arrays-ds/problem

    private static List<int> Reverse(List<int> a)
    {
        int[] reversedArray = new int[a.Count];

        for (int i = 0; i < a.Count; i++)
        {
            reversedArray[i] = a[a.Count - 1 - i];
        }

        return reversedArray.ToList();
    }

    private static void PrintList<T>(List<T> list)
        => list.ForEach(x => Console.Write($"{x.ToString()} "));

    public static void Execute()
    {
        Console.WriteLine("\n-> Reverse Array Exercise");

        List<int> list = new(){ 1, 4, 3, 2 };

        Console.Write("Initial List:  ");
        
        PrintList(list);

        var reversedList = Reverse(list);

        Console.Write("\nReversed List: ");

        PrintList(reversedList);
    }
}
