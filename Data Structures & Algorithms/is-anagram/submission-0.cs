public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] sFreq = new int[256];
        int[] tFreq = new int[256];

        // Populate frequency arrays using character ASCII values
        for (int i = 0; i < s.Length; i++) {
            sFreq[s[i]]++; // Correct: Use the character's ASCII value as the index
            tFreq[t[i]]++;
        }

        // Compare all 256 indices (full ASCII range)
        for (int i = 0; i < 256; i++) {
            if (sFreq[i] != tFreq[i]) {
                return false;
            }
        }

        return true;
    }
}