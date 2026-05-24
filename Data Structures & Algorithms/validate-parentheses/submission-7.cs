public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char l in s)
        {
           switch(l)
           {
            case '(' : stack.Push(')'); break;
            case '[' : stack.Push(']'); break;
            case '{' : stack.Push('}'); break;

            default:
                if(!stack.TryPop(out char x) || x!=l)
                {
                    return false;
                }
                break;
           }
        }
        return stack.Count == 0;
    }
}
