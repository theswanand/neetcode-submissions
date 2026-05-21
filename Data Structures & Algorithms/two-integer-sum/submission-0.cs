public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new(); // num -> index

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (dict.ContainsKey(diff)) {
                return new int[] { dict[diff], i };
            }
            dict[nums[i]] = i;
        }

        return new int[] {0,0};
    }
}
