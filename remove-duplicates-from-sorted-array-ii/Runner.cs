namespace remove_duplicates_from_sorted_array_ii
{
    public class Runner
    {
        public static void Run() 
        {
            TestCase1();
            TestCase2();   
            TestCase3();
        }

        private static void TestCase1()
        {
            var solution = new Solution();
            int[] nums = {1,1,1,2,2,3}; // Input array
            Console.WriteLine("nums = [{0}]", string.Join(", ", nums));
            int[] expectedNums = {1,1,2,2,3}; // The expected answer with correct length
            Console.WriteLine("expectedNums = [{0}]", string.Join(", ", expectedNums));

            int k = solution.RemoveDuplicates(nums); // Calls your implementation

            if(k != expectedNums.Length) 
                throw new Exception($"remove_duplicate_from_sorted_array failed. k is {k} while expectedNums.Length is {expectedNums.Length}");

            for (int i = 0; i < k; i++) {
                if(nums[i] != expectedNums[i]) 
                    throw new Exception($"remove_duplicate_from_sorted_array failed. nums[{i}] ({nums[i]}) != expectedNums[{i}] ({expectedNums[i]})");
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expectedNums));
            Console.WriteLine("Output [{0}]", string.Join(", ", nums.Take(k)));
            Console.WriteLine($"k is {k}");
        }

        private static void TestCase2()
        {
            var solution = new Solution();
            int[] nums = {0,0,1,1,1,1,2,3,3}; // Input array
            Console.WriteLine("nums = [{0}]", string.Join(", ", nums));
            int[] expectedNums = {0,0,1,1,2,3,3}; // The expected answer with correct length
            Console.WriteLine("expectedNums = [{0}]", string.Join(", ", expectedNums));

            int k = solution.RemoveDuplicates(nums); // Calls your implementation

            if(k != expectedNums.Length) 
                throw new Exception($"remove_duplicate_from_sorted_array failed. k is {k} while expectedNums.Length is {expectedNums.Length}");

            for (int i = 0; i < k; i++) {
                if(nums[i] != expectedNums[i]) 
                    throw new Exception($"remove_duplicate_from_sorted_array failed. nums[{i}] ({nums[i]}) != expectedNums[{i}] ({expectedNums[i]})");
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expectedNums));
            Console.WriteLine("Output [{0}]", string.Join(", ", nums.Take(k)));
            Console.WriteLine($"k is {k}");
        }

        private static void TestCase3()
        {
            var solution = new Solution();
            int[] nums = {0,1,1,1,1,2,3,3}; // Input array
            Console.WriteLine("nums = [{0}]", string.Join(", ", nums));
            int[] expectedNums = {0,1,1,2,3,3}; // The expected answer with correct length
            Console.WriteLine("expectedNums = [{0}]", string.Join(", ", expectedNums));

            int k = solution.RemoveDuplicates(nums); // Calls your implementation

            if(k != expectedNums.Length) 
                throw new Exception($"remove_duplicate_from_sorted_array failed. k is {k} while expectedNums.Length is {expectedNums.Length}");

            for (int i = 0; i < k; i++) {
                if(nums[i] != expectedNums[i]) 
                    throw new Exception($"remove_duplicate_from_sorted_array failed. nums[{i}] ({nums[i]}) != expectedNums[{i}] ({expectedNums[i]})");
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expectedNums));
            Console.WriteLine("Output [{0}]", string.Join(", ", nums.Take(k)));
            Console.WriteLine($"k is {k}");
        }
    }
}