using System.Diagnostics;
// Jaden Olvera Lab 2 - Merge Sort

CombineSortedTest();
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

// Test method for non-Recursive sorted list combine
static void CombineSortedTest()
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