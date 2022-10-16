public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        if (d > jobDifficulty.Length) return -1;

        long[,] dp = new long[jobDifficulty.Length + 1, d + 1];

        for (int i = 1; i <= jobDifficulty.Length; i++) {
            dp[i, 0] = int.MaxValue;
        }

        for (int i = 1; i <= d; i++) {
            dp[0, i] = int.MaxValue;
        }

        for (int i = 1; i <= jobDifficulty.Length; i++) {
            for (int j = 1; j <= d; j++) {
                dp[i, j] = int.MaxValue;

                if (j > i) {
                    continue;
                }

                int max = int.MinValue;
                for (int k = i; k >= 1; k--) {
                    max = Math.Max(max, jobDifficulty[k - 1]);
                    dp[i, j] = Math.Min(dp[i, j], dp[k - 1, j - 1] + max);
                }

            }
        }

        var res = dp[jobDifficulty.Length, d];
        return res >= int.MaxValue ? -1 : (int) res;
    }
}
