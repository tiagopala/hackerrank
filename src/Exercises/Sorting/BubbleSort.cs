namespace Exercises.Sorting;

// Visit problem at https://www.hackerrank.com/challenges/30-sorting/problem

public static class ListExtensions
{
    public static void SwapElements(this List<int> list, int firstPosition, int secondPosition)
        => (list[secondPosition], list[firstPosition]) = (list[firstPosition], list[secondPosition]);
}

public class Solution
{
    public static List<int> BubbleSort(List<int> list)
    {

        for (int i = 0; i < list.Count; i++)
        {
            bool swapped = false;

            for (int j = 0; j < list.Count - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    list.SwapElements(j, j + 1);
                    swapped = true;
                }

            }

            if (!swapped)
                break;
        }

        return list;
    }
}