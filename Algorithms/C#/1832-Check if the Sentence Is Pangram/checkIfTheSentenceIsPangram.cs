//-----------------------------------------------------------------------------
// Runtime: 129ms
// Memory Usage: 36.6 MB
// Link: https://leetcode.com/submissions/detail/824664181/
//-----------------------------------------------------------------------------

public class Solution {
    public bool CheckIfPangram(string sentence) {
        var hashSet = new HashSet<char>();
        foreach(char c in sentence){
            if(hashSet.Count >= 26) return true;
            hashSet.Add(c);
        }
        
        return hashSet.Count >= 26;
    }
}
