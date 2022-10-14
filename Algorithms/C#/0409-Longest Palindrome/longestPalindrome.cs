//-----------------------------------------------------------------------------
// Runtime: 94ms
// Memory Usage: 35 MB
// Link: https://leetcode.com/submissions/detail/822346679/
//-----------------------------------------------------------------------------

public class Solution {
    public int LongestPalindrome(string s) {
        if(s.Length == 1) return s.Length;
        
        var countDict = new Dictionary<char, int>();
        
        foreach(char c in s){
            if(!countDict.ContainsKey(c)){
                countDict[c] = 1;
            }
            else{
                countDict[c]++;
            }
        }
        
        var result = 0;
        var odd = 0;
        foreach (var ch in countDict.Keys)
        {
            odd |= countDict[ch] & 1;
            result += countDict[ch] / 2;
        }
        
        return result * 2 + odd;
    }
}
