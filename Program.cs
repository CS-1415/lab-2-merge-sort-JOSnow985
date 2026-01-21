using System.Diagnostics;
// Jaden Olvera Lab 2 - Merge Sort

TestCombineSorted();
TestMergesort();
// Should only be reachable if the tests have passed.
Console.WriteLine("Tests passed.");


// Takes two sorted lists and returns a sorted list that includes all values from a and b
static int[] CombineSortedArrays(int[] leftArray, int[] rightArray)
{
    int leftIndex = 0;
    int rightIndex = 0;
    int[] combinedArray = new int[leftArray.Length + rightArray.Length];
    for (int combinedIndex = 0; combinedIndex < combinedArray.Length; combinedIndex++)
    {
        // Checks if we've looked through right array entirely, then if we've gone through left array entirely
        // finally compares left to right and decides which one is greater
        if (rightIndex >= rightArray.Length || (leftIndex < leftArray.Length && leftArray[leftIndex] < rightArray[rightIndex]))
        {
            combinedArray[combinedIndex] = leftArray[leftIndex];
            leftIndex++;
        }
        // If left array is done or right array @ right index is bigger than left array @ left index, we do this
        else
        {
            combinedArray[combinedIndex] = rightArray[rightIndex];
            rightIndex++;
        }
    }
    return combinedArray;

}

// Takes an array and returns that array if array.Length < 2 or 
// splits it in half, runs itself on both halves, and returns that combined array
static int[] SortViaMergesort(int[] array)
{
    return [];
}

// Test method for non-Recursive sorted list combine
static void TestCombineSorted()
{
    // Will it combine a and b if a is longer?
    Debug.Assert(Enumerable.SequenceEqual(
        CombineSortedArrays(
            [-5, 2, 5, 8, 10], 
            [1, 2, 5]
            ),
            [-5, 1, 2, 2, 5, 5, 8, 10]
        ));
    // Will it combine a and b if b is longer?
    Debug.Assert(Enumerable.SequenceEqual(
        CombineSortedArrays(
            [-5, 2, 3], 
            [1, 2, 5, 7, 9]
            ),
            [-5, 1, 2, 2, 3, 5, 7, 9]
        ));
    // Will it combine a and b if a ends before b?
    Debug.Assert(Enumerable.SequenceEqual(
        CombineSortedArrays(
            [-5, 2, 8], 
            [1, 2, 3, 4, 5, 7, 9, 15, 20, 25]
            ),
            [-5, 1, 2, 2, 3, 4, 5, 7, 8, 9, 15, 20, 25]
        ));
}

// Test method for SortViaMergesort
static void TestMergesort()
{
    Debug.Assert(Enumerable.SequenceEqual(
        SortViaMergesort([6, 1, -5, 3, 5, 3, 7]),
        [-5, 1, 3, 3, 5, 6, 7]));
    Debug.Assert(Enumerable.SequenceEqual(
        SortViaMergesort([1, 10, -5, 2, 5, 2, 5, 8]),
        [-5, 1, 2, 2, 5, 5, 8, 10]));


}