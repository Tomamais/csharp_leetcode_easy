namespace zigzag_conversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var goingDown = true;
            var matrix = new string[numRows];
            int row = 0;

            for (var i = 0; i < s.Length; i++)
            {
                matrix[row] += s[i];
                if (row == numRows - 1)
                {
                    goingDown = false;
                }
                else if(row == 0)
                {
                    goingDown = true;
                }
                if(goingDown) row++;
                else row--;
            }

            var finalString = "";
            for (var i = 0; i < numRows; i++)
            {
                finalString += matrix[i];
            }

            return finalString;
        }
    }
}