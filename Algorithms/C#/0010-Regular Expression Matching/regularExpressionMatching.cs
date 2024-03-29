public class Solution {
    public bool IsMatch(string s, string p) {
        var dp = new bool[s.Length + 1, p.Length + 1];
        dp[s.Length, p.Length] = true;

        for (var i = s.Length; i >= 0; i--)
            for (var j = p.Length - 1; j >= 0; j--)
            {
                var match = i < s.Length && (s[i] == p[j] || p[j] == '.');
                if (j + 1 < p.Length && p[j + 1] == '*')
                    dp[i, j] = dp[i, j + 2] || (match && dp[i + 1, j]);
                else
                    dp[i, j] = match && dp[i + 1, j + 1];
            }

        return dp[0, 0];
    }
}
