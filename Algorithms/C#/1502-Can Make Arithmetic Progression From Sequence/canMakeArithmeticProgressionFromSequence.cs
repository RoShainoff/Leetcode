//-----------------------------------------------------------------------------
// Runtime: 119ms
// Memory Usage: 39.8 MB
// Link: https://leetcode.com/submissions/detail/822360350/
//-----------------------------------------------------------------------------

public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
                
        Array.Sort(arr);
        
        var diff = arr[1] - arr[0];
        
        for(int i = 1; i < arr.Length - 1; i++){
            if(arr[i + 1] - arr[i] != diff){
                return false;
            }
        }
        
        return true;
    }
}
