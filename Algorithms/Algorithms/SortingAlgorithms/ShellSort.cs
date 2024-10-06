namespace Csharp_Learnings.Algorithms.SortingAlgorithms;

public class ShellSort {
    public static void Sort(params int[] unsortedNumbers)
    {
        for (int h = unsortedNumbers.Length / 2; h > 0; h /= 2)
        {
            for (int i = h; i < unsortedNumbers.Length; i++)
            {
                int j = i;
                int ai = unsortedNumbers[i];
                while (j >= h && unsortedNumbers[j - h] > ai)
                {
                    unsortedNumbers[j] = unsortedNumbers[j - h];
                    j -= h;
                }
                unsortedNumbers[j] = ai;
            }
        }
    }
}