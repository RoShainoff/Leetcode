public class Solution {
    public int LargestPerimeter(int[] nums) {
        
        if(nums.Length < 3) return 0;
        
        Array.Sort(nums);
        for (int i = nums.Length - 3; i >= 0; i--)
        {
            if (nums[i] + nums[i + 1] > nums[i + 2])
                return nums[i] + nums[i + 1] + nums[i + 2];
        }
        
        return 0;
    }
}
