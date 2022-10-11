public class Solution {
    public int MyAtoi(string str) {
        if (string.IsNullOrWhiteSpace(str)) { return 0; }

            var isNegative = false;
            var index = 0;

            while (index < str.Length && str[index] == ' ') { index++; }

            if (str[index] == '-')
            {
                isNegative = true;
                index++;
            }
            else if (str[index] == '+')
            {
                index++;
            }

            var positiveOverflowHead = int.MaxValue / 10;
            var positiveOverflowTail = int.MaxValue % 10;

            var result = 0;
            for (; index < str.Length; index++)
            {
                var digit = str[index] - '0';
                if (digit < 0 || digit > 9) { break; }

                if (result > positiveOverflowHead ||
                    (result == positiveOverflowHead && digit > positiveOverflowTail))
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }

                result = result * 10 + digit;
            }

            return isNegative ? -result : result;
    }
}
