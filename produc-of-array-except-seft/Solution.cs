namespace product_of_array_except_self
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            /* horrible performance solution
            
            int[] answers = new int[nums.Length];
            int[] cache = nums;

            for(int i = 0;i < nums.Length;i++)
            {
                int product = 1;
                for(int j = 0;j < nums.Length;j++)
                {
                    if (i != j)
                    {
                        product = product * nums[j];
                    }
                }
                answers[i] = product;
            }
            */

            int n = nums.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            int[] answer = new int[n];

            // Calculate the product of all elements to the left of each element
            int product = 1;
            for (int i = 0; i < n; i++)
            {
                left[i] = product;
                product *= nums[i];
            }
            Console.WriteLine("left = [{0}]", string.Join(", ", left));

            // Calculate the product of all elements to the right of each element
            product = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                right[i] = product;
                product *= nums[i];
            }
            Console.WriteLine("right = [{0}]", string.Join(", ", right));

            // Calculate the final answer array
            for (int i = 0; i < n; i++)
            {
                answer[i] = left[i] * right[i];
            }

            Console.WriteLine("answer = [{0}]", string.Join(", ", answer));
            return answer;
        }
    }
}