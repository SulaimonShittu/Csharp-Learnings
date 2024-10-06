namespace Csharp_Learnings.Algorithms.SortingAlgorithms;

public class MergeSort {
   
    public static void Sort(params int[] unsortedNumbers)
    {
        if (unsortedNumbers.Length <= 1) { return; }
        int m = unsortedNumbers.Length / 2;
        int[] left = GetSubarray(unsortedNumbers, 0, m - 1);
        
        int[] right = GetSubarray(unsortedNumbers, m, unsortedNumbers.Length - 1);
        Sort(left);
        Sort(right);
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j]) { unsortedNumbers[k] = left[i++]; }
            else { unsortedNumbers[k] = right[j++]; }
            k++;
        }
        while (i < left.Length) { unsortedNumbers[k++] = left[i++]; }
        while (j < right.Length) { unsortedNumbers[k++] = right[j++]; }
    }
    static int[] GetSubarray(int[] a, int si, int ei)
    {
        int[] result = new int[ei - si + 1];
        Array.Copy(a, si, result, 0, ei - si + 1);
        return result;
    }
}