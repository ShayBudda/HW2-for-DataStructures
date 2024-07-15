using System;
namespace HW2;
class Program
{
    static void Main()
    {
        //I tested this with medium, small, and large arrays, and they all work
        int[] arr1 = { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12 ,13, 13, 14, 14, 15, 15, 16, 16, 17, 17 };
        int result = FindSingleElement(arr1);
        Console.WriteLine("The element that appears only once is: " + result);
    }

    static int FindSingleElement(int[] arr)
    {
        int low = 0; //int low is the integer that appears at the index of 0 aka the first number on the list
        int high = arr.Length - 1; //the highest is the last integer on the list

        while (low < high) //this while loop goes on until the lowest and the highest index are the same narrowing down th correct int
        {
            int mid = low + (high - low) / 2; //this splits the array in half

            // this ensures the mid is even
            if (mid % 2 != 0) 
            {
                mid--;  // if the mid index is not even it drops to one index lower thus making it so
            }

            // Check if the unique element is in the left half or right half
            if (arr[mid] == arr[mid + 1]) //if the number next to the int at mid is the same number, it rules out the bottom half
            {                             //because the extra number would make the whole array be odd. if the number to the right is the same
                low = mid + 2;            //the odd number is not offsetting the pair afterwards
            }                              //the reason we add 2 to the new starting index is because we already know that the two are the same and aren't our target
            else
            {
                high = mid;                //if the numbers are different we can assume the odd number has offset the array making mid the new high number
            }                               // this will take the bottom half
        }

        // When low and high converge, they point to the single element
        return arr[low];
    }
}
