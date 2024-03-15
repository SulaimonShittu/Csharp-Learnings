namespace Csharp_Learnings.Algorithms.SortingAlgorithms;

public static class InsertionSort
{
    public static void Sort(int[] unsortedNumbers)
    {
        for (int i = 1; i < unsortedNumbers.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (unsortedNumbers[j+1] < unsortedNumbers[j])
                {
                    (unsortedNumbers[j + 1], unsortedNumbers[j]) = (unsortedNumbers[j], unsortedNumbers[j + 1]);
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(String.Join(",", unsortedNumbers));
    }
}