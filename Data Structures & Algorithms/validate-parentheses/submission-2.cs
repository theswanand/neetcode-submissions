public class Solution {
    public bool IsValid(string s) {
        if(s == String.Empty) return true;
        Stack<char> stack = new();
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if(stack.Count == 0) return false;
                var last = stack.Peek();
                if(((last == '(' && c == ')') || (last == '{' && c == '}') || (last == '[' && c == ']')) 
                    && stack.Count > 0)
                {
                    stack.Pop();
                    continue;
                }
                else
                return false;
            }
        }
        return stack.Count == 0 && true;
    }
}
