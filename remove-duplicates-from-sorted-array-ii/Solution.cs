namespace remove_duplicates_from_sorted_array_ii
{
    public class Solution 
{
        public int RemoveDuplicates(int[] nums) {
            int k = 1;

            int previousElement = nums[0];
            int instancesOfElement = 1;

            for(var i = 1;i < nums.Length;i++)
            {
                if(previousElement == nums[i] && instancesOfElement < 2)
                {
                    instancesOfElement++;
                    k++;
                }
                else if(previousElement != nums[i])
                {
                    previousElement = nums[i];
                    nums[k] = previousElement;
                    instancesOfElement = 1;
                    k++;
                }
            }
            // covers the last element
            if (instancesOfElement == 2) nums[k -1] = previousElement;

            return k;
        }

        // optimal solution from leetcode
        public int RemoveDuplicatesOptimal(int[] nums) {
            if (nums.Length <= 2) 
            { // If array length is 2 or less, no duplicates to remove
                return nums.Length;
            }

            int count = 2; // Count of allowed duplicates

            for (int i = 2; i < nums.Length; i++) 
            { // Iterate through the array starting from the third element
                if (nums[i] != nums[count - 2]) 
                { // If current element is different from element at count-2, it is a non-duplicate
                    nums[count] = nums[i]; // Overwrite duplicates with non-duplicates
                    count++; // Increment count of non-duplicates
                }
            }

            return count; // Length of modified array with duplicates removed
        }
    }
}