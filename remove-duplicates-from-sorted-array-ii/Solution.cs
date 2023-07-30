namespace remove_duplicates_from_sorted_array_ii
{
    public class Solution 
{
        public int RemoveDuplicates(int[] nums) {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }

            int k = 2;

            for (var i = 2;i < nums.Length;i++)
            {
                if(nums[i] != nums[k - 2])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

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