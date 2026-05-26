public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int x;
        int n;
        int l;
        foreach(string t in tokens)
        {
            switch(t)
            {
                case "*":
                    x = stack.Pop();
                    n = stack.Pop();
                    l = n * x;
                    stack.Push(l);
                break;

                case "/":
                    x = stack.Pop();
                    n = stack.Pop();
                    l = n / x;
                    stack.Push(l);
                break;

                case "+":
                    x = stack.Pop();
                    n = stack.Pop();
                    l = n + x;
                    stack.Push(l);
                break;

                case "-":
                    x = stack.Pop();
                    n = stack.Pop();
                    l = n - x;
                    stack.Push(l);
                break;

                default:
                    int num = int.Parse(t);
                    stack.Push(num);
                break;
            }
        }
        return stack.Peek();
    }
}
