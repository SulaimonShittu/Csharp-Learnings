namespace Csharp_Learnings.Algorithms.SortingAlgorithms;

public static class BubbleSort
{
    public static void Sort(params int[] list)
    {
        for (int i = 0; i < list.Length-1; i++)
        {
            for (int j = 0; j < list.Length - 1; j++)
            {
                if (list[j + 1] < list[j])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }

        Console.WriteLine(String.Join(',', list));
    }
}