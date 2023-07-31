namespace product_of_array_except_self
{
    public class Runner
    {
        public static void Run() 
        {
            TestCase1();
            TestCase2();
        }

        private static void TestCase1()
        {
            var solution = new Solution();
            int[] nums = {1,2,3,4}; // Input array
            Console.WriteLine("nums = [{0}]", string.Join(", ", nums));
            int[] expectedNums = {24,12,8,6}; // The expected answer with correct length
            Console.WriteLine("expectedNums = [{0}]", string.Join(", ", expectedNums));

            var answers = solution.ProductExceptSelf(nums); // Calls your implementation

            for (int i = 0; i < answers.Length - 1; i++) {
                if(answers[i] != expectedNums[i]) 
                    throw new Exception($"product_of_array_except_self failed. answers[{i}] ({answers[i]}) != expectedNums[{i}] ({expectedNums[i]})");
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expectedNums));
            Console.WriteLine("Output [{0}]", string.Join(", ", answers));
        }


        private static void TestCase2()
        {
            var solution = new Solution();
            int[] nums = {-1,1,0,-3,3}; // Input array
            Console.WriteLine("nums = [{0}]", string.Join(", ", nums));
            int[] expectedNums = {0,0,9,0,0}; // The expected answer with correct length
            Console.WriteLine("expectedNums = [{0}]", string.Join(", ", expectedNums));

            var answers = solution.ProductExceptSelf(nums); // Calls your implementation

            for (int i = 0; i < answers.Length - 1; i++) {
                if(answers[i] != expectedNums[i]) 
                    throw new Exception($"product_of_array_except_self failed. answers[{i}] ({answers[i]}) != expectedNums[{i}] ({expectedNums[i]})");
            }

            Console.WriteLine("Expected = [{0}]", string.Join(", ", expectedNums));
            Console.WriteLine("Output [{0}]", string.Join(", ", answers));
        }
    }
}