public class Solution {
    public bool IsValid(string s) {
        Stack<int> stack = new Stack<int>();

        foreach(char l in s)
        {
            if(l==')')
            {
                if(stack.TryPeek(out int x) && x=='(')
                {
                    stack.Pop();
                }else
                {
                    return false;
                }
            }else if(l==']')
            {
                if(stack.TryPeek(out int x) && x=='[')
                {
                    stack.Pop();
                }else
                {
                    return false;
                }
            }else if(l=='}')
            {
                if(stack.TryPeek(out int x) && x=='{')
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
        if(stack.Count==0)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
