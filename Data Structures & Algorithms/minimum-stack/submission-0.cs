public class MinStack {
    Stack<(int, int)> stack;

    public MinStack() {
        stack = new();
    }
    
    public void Push(int val) {
        if(stack.Count == 0)
            stack.Push((val, val));
        else
        {
            var (num, min) = stack.Peek();
            var min1 = Math.Min(min, val);
            stack.Push((val, min1));
        }
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().Item1;
    }
    
    public int GetMin() {
        return stack.Peek().Item2;
    }
}
