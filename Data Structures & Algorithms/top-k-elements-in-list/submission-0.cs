public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int , int> dict = new ();
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        }
        return dict.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).Take(k).ToArray();
    }
}
