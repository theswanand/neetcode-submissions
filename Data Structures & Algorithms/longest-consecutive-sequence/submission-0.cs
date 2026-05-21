public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int max = 0;
        foreach(int num in nums)
        {
            if(set.Contains(num - 1))
                continue;
            else
            {
                bool IsSeq = true;
                int localMax = 1;
                int n = num;
                while(set.Contains(n + 1))
                {
                    localMax++;
                    n++;
                }
                max = Math.Max(max, localMax);
            }
        }
        return max;
    }
}
