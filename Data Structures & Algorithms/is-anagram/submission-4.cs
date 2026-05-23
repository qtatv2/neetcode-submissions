public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach(char w in s)
        {
            map[w] = map.GetValueOrDefault(w, 0) + 1;
        }

        foreach(char w in t)
        {
            if (!map.ContainsKey(w) || map[w] == 0) 
            {
                return false;
            }
            map[w]--;
        }
        return true;
    }
}
