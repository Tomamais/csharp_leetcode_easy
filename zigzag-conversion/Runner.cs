namespace zigzag_conversion
{
    public class Runner
    {
        public static void Run() 
        {
            TestCase1();
            TestCase2();
            TestCase3();
            TestCase4();
        }

        private static void TestCase1()
        {
            var solution = new Solution();
            var input = "PAYPALISHIRING";
            var expected = "PAHNAPLSIIGYIR";
            int numRows = 3;
            string output = solution.Convert(input, numRows);
            System.Console.WriteLine($"Input: {input}");
            System.Console.WriteLine($"Output: {output}");
            System.Console.WriteLine($"Expected: {expected}");
            System.Console.WriteLine($"Result: {String.Compare(output, expected) == 0}");
        }

        private static void TestCase2()
        {
            var solution = new Solution();
            var input = "PAYPALISHIRING";
            var expected = "PINALSIGYAHRPI";
            int numRows = 4;
            string output = solution.Convert(input, numRows);
            System.Console.WriteLine($"Input: {input}");
            System.Console.WriteLine($"Output: {output}");
            System.Console.WriteLine($"Expected: {expected}");
            System.Console.WriteLine($"Result: {String.Compare(output, expected) == 0}");
        }

        private static void TestCase3()
        {
            var solution = new Solution();
            var input = "ABC";
            var expected = "ACB";
            int numRows = 2;
            string output = solution.Convert(input, numRows);
            System.Console.WriteLine($"Input: {input}");
            System.Console.WriteLine($"Output: {output}");
            System.Console.WriteLine($"Expected: {expected}");
            System.Console.WriteLine($"Result: {String.Compare(output, expected) == 0}");
        }

        private static void TestCase4()
        {
            var solution = new Solution();
            var input = "ABCD";
            var expected = "ABDC";
            int numRows = 3;
            string output = solution.Convert(input, numRows);
            System.Console.WriteLine($"Input: {input}");
            System.Console.WriteLine($"Output: {output}");
            System.Console.WriteLine($"Expected: {expected}");
            System.Console.WriteLine($"Result: {String.Compare(output, expected) == 0}");
        }
    }
}