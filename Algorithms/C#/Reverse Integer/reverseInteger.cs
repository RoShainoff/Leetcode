public class Solution {
    public int Reverse(int x)
    {
        var result = 0;

        var positiveOverflow = int.MaxValue / 10;
        var negativeOverflow = int.MinValue / 10;

        for (; x != 0; x /= 10)
        {
            if (result > positiveOverflow || result < negativeOverflow)
            {
                return 0;
            }
            result = result * 10 + x % 10;
        }

        return result;
    }
}
