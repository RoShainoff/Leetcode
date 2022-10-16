public class Solution {
    public int Search(int[] nums, int target) {
        
        int low = 0, high = nums.Length - 1;

        while (low <= high)
        {
            var middle = low + (high - low) / 2;
            if (nums[middle] == target) return middle;
            else if (nums[middle] > target) high = middle - 1;
            else low = middle + 1;
        }

        return -1;
    }
}
