public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0) return false;
        Array.Sort(nums);
        int curr = nums[0];
        for(int i = 1; i < nums.Length; i++)
            if(nums[i] == curr)
                return true;
            else
                curr = nums[i];
        return false;
    }
}
