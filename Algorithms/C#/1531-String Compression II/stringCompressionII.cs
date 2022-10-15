//-----------------------------------------------------------------------------
// Runtime: 111ms
// Memory Usage: 48.7 MB
// Link: https://leetcode.com/submissions/detail/823123691/
//-----------------------------------------------------------------------------

public class Solution {    
    public int GetLengthOfOptimalCompression(string s, int k) {
        var memo = new int[s.Length, k + 1];
        return Helper(s, 0, k, memo);
    }
    
    private int Helper(string s, int start, int k, int[,] memo){
        if(start >= s.Length || s.Length - start <= k){
            return 0;
        }
        
        if(memo[start, k] != 0){
            return memo[start, k];
        }
        
        int[] freq = new int[26];
        int maxFreq = 0;
        int answer = s.Length;
        
        for(int i = start;i < s.Length;i++){
            freq[s[i] - 'a'] += 1;
            maxFreq = Math.Max(maxFreq, freq[s[i] - 'a']);
            // we are mot considering maxFreq > 1 i.e. a1 will be a, but aaa will be a3
            int len = 1 + (maxFreq > 1 ? maxFreq.ToString().Length : 0);
            if(k >= i - start + 1 - maxFreq){
                answer = Math.Min(answer, len + Helper(s, i + 1, k - (i - start + 1 - maxFreq), memo));
            }
        }
        
        memo[start, k] = answer;
        return answer;
    }
}
