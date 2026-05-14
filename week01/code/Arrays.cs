public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        
        // Step 1: Create an array that will store the multiples.

        // Step 2: Use a loop to go from 1 up to the number of multiples.

        // Step 3: During each loop iteration, calculate the multiple
        // by multiplying the starting number by the current loop number.

        // Step 4: Store the calculated multiple into the correct position in the array.

        // Step 5: After all multiples have been calculated and stored, return the completed array.

        var result = new double [length]; // Create the result array, the size should be 'length'

        for (int i = 1; i <= length; i++) // Loop from 1 to 'length' inclusive
        {
            result[i - 1] = number * i; // Set the value at index i-1 to be number multiplied by i, store the array
        }

        return result; // return the array
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine how many items need to be moved from the end of the list to the front based on the rotation amount.

        // Step 2: Create a temporary list to store the rotated result.

        // Step 3: Copy the last 'amount' elements from the original list into the temporary list first.

        // Step 4: After the last elements have been added, copy the remaining elements from the beginning of the original list
        // into the temporary list.

        // Step 5: Clear the original list so it can be updated with the rotated values.

        // Step 6: Copy all values from the temporary list back into the original list in the new rotated order.

        // Step 7: The list is now rotated to the right by the given amount.



         // Step 1: Create a temporary list to store the rotated values.
        List<int> rotated = new List<int>();

        // Step 2: Add the last 'amount' elements from the original list
        // to the temporary list.
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            rotated.Add(data[i]);
        }

        // Step 3: Add the remaining elements from the beginning of the original list to the temporary list.
        for (int i = 0; i < data.Count - amount; i++)
        {
            rotated.Add(data[i]);
        }

        // Step 4: Clear the original list.
        data.Clear();

        // Step 5: Copy the rotated values back into the original list.
        foreach (int item in rotated)
        {
            data.Add(item);
        }
        }
}
