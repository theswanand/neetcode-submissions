public class Solution {

    // Encodes a list of strings to a single string.
    public string Encode(IList<string> strs) {
        StringBuilder sb = new();
        foreach (string str in strs) {
            sb.Append(str.Length).Append('#').Append(str);
        }
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            // Find the position of '#'
            while (s[j] != '#') j++;
            int length = int.Parse(s.Substring(i, j - i));
            string str = s.Substring(j + 1, length);
            result.Add(str);
            i = j + 1 + length;
        }
        return result;
    }
}
