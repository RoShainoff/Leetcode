//-----------------------------------------------------------------------------
// Runtime: 105ms
// Memory Usage: 37.8 MB
// Link: https://leetcode.com/submissions/detail/822354571/
//-----------------------------------------------------------------------------

public class Solution {
    public int ArraySign(int[] nums) {        
        var negative = 0;
        
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0) return 0;
            
            if(nums[i] < 0)
                negative++;
        }
        
        if(negative % 2 == 1)
            return -1;
        else 
            return 1;
    }
}
