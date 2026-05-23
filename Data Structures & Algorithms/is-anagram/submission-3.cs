public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char w in s)
        {
            map[w] = map.GetValueOrDefault(w, 0) + 1;
        }

        foreach(char w in t)
        {
            if(map.ContainsKey(w))
            {
                if(map[w]>0)
                {
                    map[w]--;
                }
            }else
            {
                return false;
            }
        }
        int sum = 0;
        foreach (int val in map.Values) 
        {
            sum += val;
        }
        if(sum == 0)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
