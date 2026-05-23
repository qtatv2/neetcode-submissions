public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            int x = target - nums[i];
            if(map.ContainsKey(x))
            {
                return [map[x], i];
            }else
            {
                map[nums[i]] = i;
            }

        }
        return [0, 0];
    }
}
