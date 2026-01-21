using System.Diagnostics;
// Jaden Olvera Lab 2 - Merge Sort

CombineSortedTest();
// Should only be reachable if the tests have passed.
Console.WriteLine("Tests passed.");


// Takes two sorted lists and returns a sorted list that includes all values from a and b
// Not Recursive
static int[] CombineSortedArrays(int[] a, int[] b)
{
    return [];
}

// Test method for non-Recursive sorted list combine
static void CombineSortedTest()
{
    Debug.Assert(Enumerable.SequenceEqual(
        CombineSortedArrays(
            [-5, 2, 5, 8, 10], 
            [1, 2, 5]
            ),
            [-5, 1, 2, 2, 5, 5, 8, 10]
        ));
}