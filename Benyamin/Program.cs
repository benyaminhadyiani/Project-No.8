﻿// Initialize the first array with some integer values
int[] array1 = { 1, 2, 0, 11, 5, 6 };
// Initialize the second array with some integer values
int[] array2 = { 7, 8, 9, 12, 11, 0 };
// Call the MergeArrays function to merge array1 and array2, removing duplicates
int[] mergedArray = MergeArrays(array1, array2);
// Output the result to the console
Console.WriteLine("merged arrays without duplicate: ");
Console.WriteLine(string.Join(" ", mergedArray));
// Define a static method to merge two integer arrays
static int[] MergeArrays(int[] array1, int[] array2)
{
    // Concatenate array1 and array2, remove duplicates using Distinct(), and convert the result back to an array
    return array1.Concat(array2).Distinct().ToArray();
}