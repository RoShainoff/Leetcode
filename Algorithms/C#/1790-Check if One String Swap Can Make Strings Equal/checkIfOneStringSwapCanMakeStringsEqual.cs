//-----------------------------------------------------------------------------
// Runtime: 90 ms
// Memory Usage: 37.7 MB
// Link: https://leetcode.com/submissions/detail/822413999/
//-----------------------------------------------------------------------------

public class Solution {
    private readonly Dictionary<char, int> allLetters = new Dictionary<char, int>{
            {'a', 0},
            {'b', 0},
            {'c', 0},
            {'d', 0},
            {'e', 0},
            {'f', 0},
            {'g', 0},
            {'h', 0},
            {'i', 0},
            {'j', 0},
            {'k', 0},
            {'l', 0},
            {'m', 0},
            {'n', 0},
            {'o', 0},
            {'p', 0},
            {'q', 0},
            {'r', 0},
            {'s', 0},
            {'t', 0},
            {'u', 0},
            {'v', 0},
            {'w', 0},
            {'x', 0},
            {'y', 0},
            {'z', 0}
        };
    
    public bool AreAlmostEqual(string s1, string s2) {
                
        if(s1 == s2) return true;
        
        var swap = 0;
        
        foreach(char c in s1){
            allLetters[c]++;
        }
                
        for(int i = 0; i < s2.Length; i++){            
            if(allLetters[s2[i]] <= 0){
                return false;
            }
            else{
                allLetters[s2[i]]--;
            }
            
            if(s1[i] != s2[i]){
                swap++;
            }
            
            if(swap > 2) return false;
        }
        
        
        return true;
    }
}
