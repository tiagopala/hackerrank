# Bubble Sort

It's one of the most simple sorting algorithms, but also very inefficient as well.

It's a good sorting algorithm to starting learning about sorting, but not recommended in real world scenarios.

In a few words, it basically iterate through the entire array swapping two positions one at a time until the end.

## Implementation

```csharp
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
            int numberOfSwaps = 0;

            for (int j = 0; j < list.Count - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    list.SwapElements(j, j + 1);
                    numberOfSwaps++;
                }

            }
        }

        return list;
    }
}
```