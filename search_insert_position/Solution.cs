namespace search_insert_position
{
    public class Solution {
        public int SearchInsert(int[] nums, int target) 
        {
            int result = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}