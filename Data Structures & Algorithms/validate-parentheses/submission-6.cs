public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char l in s)
        {
            if(l==')')
            {
                if(stack.TryPeek(out char x) && x=='(')
                {
                    stack.Pop();
                }else
                {
                    return false;
                }
            }else if(l==']')
            {
                if(stack.TryPeek(out char x) && x=='[')
                {
                    stack.Pop();
                }else
                {
                    return false;
                }
            }else if(l=='}')
            {
                if(stack.TryPeek(out char x) && x=='{')
                {
                    stack.Pop();
                }else
                {
                    return false;
                }
            }else
            {
                stack.Push(l);
            }
        }
        return stack.Count == 0;
    }
}
