public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0) return false;
        HashSet<int> set = new();
        for(int i = 0; i < nums.Length; i++)
            if(set.Contains(nums[i]))
                return true;
            else
                set.Add(nums[i]);

        //Array.Sort(nums);
        //int curr = nums[0];
        // for(int i = 1; i < nums.Length; i++)
        //     if(nums[i] == curr)
        //         return true;
        //     else
        //         curr = nums[i];
        return false;
    }
}
