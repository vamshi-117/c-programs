using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if the middle element is equal to the value
            if (input[mid] == value)
            {
                return mid;
            }
            // If the middle element is greater than the value, search the left half
            else if (input[mid] > value)
            {
                right = mid - 1;
            }
            // If the middle element is less than the value, search the right half
            else
            {
                left = mid + 1;
            }
        }

        // If the value is not found, return -1
        return -1;
    }
}
