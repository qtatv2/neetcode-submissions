public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        for(int i=0; i<strs.Length; i++)
        {
            int[] count = new int[26];
            for(int j=0; j<strs[i].Length; j++)
            {
                count[strs[i][j]-'a']++;
            }
            string key = string.Join(",", count);
            if(map.ContainsKey(key))
            {
                map[key].Add(strs[i]);
            }else
            {
                map[key] = new List<string>();
                map[key].Add(strs[i]);
            }
        }
        return new List<List<string>>(map.Values);
    }
}
