public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> masterDict = new();

        foreach (string str in strs)
        {
            int[] count = new int[26];
            foreach (char c in str)
                count[c - 'a']++;

            // Join counts to form a unique key for anagrams
            string key = string.Join("#", count);

            if (masterDict.ContainsKey(key))
                masterDict[key].Add(str);
            else
                masterDict[key] = new List<string>() { str };
        }

        return masterDict.Values.ToList();
    }
}
