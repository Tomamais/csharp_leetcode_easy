namespace remove_duplicate_from_sorted_array
{
    public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;

        int previousElement = nums[0];

        for (var i = 1;i < nums.Length;i++)
        {
           if(previousElement != nums[i])
           {
               previousElement = nums[i];
               nums[k] = previousElement;
               k++;
           }
        }

        return k;
    }
}
}