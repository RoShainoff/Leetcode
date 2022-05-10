public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var result = 0;
        
        for(int l = 0; l < nums.Length; l++){
            var sum = 0;
            for(int r = l; r < nums.Length; r++){
                
                sum += nums[r];
                
                if(sum == k) 
                {
                    result++;
                }
            }
        }
        
        return result;
    }
}
