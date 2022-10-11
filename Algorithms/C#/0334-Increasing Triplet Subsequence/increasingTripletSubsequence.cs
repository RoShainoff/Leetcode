/*Variant 1*/
public class Solution {
    public bool IncreasingTriplet(int[] nums) {

        var setNums = new HashSet < int > (nums);

        if (setNums.Count < 3) return false;

        var isAllByDesc = true;

        for (int i = 0; i < nums.Length - 2; i++) {
            if (nums[i] == nums[i + 1]) continue;
            for (int j = i + 1; j < nums.Length - 1; j++) {
                if (nums[j] == nums[j + 1]) continue;
                for (int k = j + 1; k < nums.Length; k++) {

                    if (nums[k] > nums[k - 1]) isAllByDesc = false;

                    if (nums[i] < nums[j] && nums[j] < nums[k]) return true;
                }

                if (isAllByDesc) return false;
            }
        }

        return false;

    }
}

/*Variant 2*/
public class Solution {
    public bool IncreasingTriplet(int[] nums) {
                 
        if (nums.Length < 3)
            return false;
        
        int minIndex  = -1;
        int midIndex  = -1;
        
        for (int i = 0; i < nums.Length; i ++)
        {
            int currentNumber = nums[i];

            if ( (midIndex > -1) && (currentNumber > nums[midIndex]) )
                return true;
                
            if ( (minIndex == -1) || (currentNumber < nums[minIndex]) )
                minIndex = i;
            
            if (currentNumber > nums[minIndex])
                midIndex = i;
        }
        
        return false;

    }
}
