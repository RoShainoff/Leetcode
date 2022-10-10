public class Solution {
    public int PivotIndex(int[] nums) {
        var sumL = 0;
        var sumR = 0;
        foreach (var num in nums)
            sumR += num;

        for (int i = 0; i < nums.Length; i++)
        {
            sumR -= nums[i];
            
            if(sumL == sumR) return i;
            
            sumL += nums[i];
        }

        return -1;
    }
}
