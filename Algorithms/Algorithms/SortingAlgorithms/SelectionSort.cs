namespace Csharp_Learnings.Algorithms.SortingAlgorithms;

public static class SelectionSort
{
    public static void Sort(int[] unsortedNumbers)
    {
        for (int i = 0; i < unsortedNumbers.Length - 1; i++)
        {
            int smallest = unsortedNumbers[i];
            int smallestIndex = i;
            for (int j = i + 1; j < unsortedNumbers.Length; j++)
            {
                if (unsortedNumbers[j] < smallest)
                {
                    smallest = unsortedNumbers[j];
                    smallestIndex = j;
                }
            }

            if (unsortedNumbers[i] != smallest)
            {
                (unsortedNumbers[i], unsortedNumbers[smallestIndex]) = (smallest, unsortedNumbers[i]);
            }
        }
        Console.WriteLine(String.Join(',',unsortedNumbers));
    }
}