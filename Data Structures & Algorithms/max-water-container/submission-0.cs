public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int l = 0;
        int r = heights.Length - 1;

        while(l<r)
        {
            int x = Math.Min(heights[l],heights[r]) * (r - l);
            if(x>max)
            {
                max = x;
            }
            if(heights[l]>heights[r])
            {
                r--;
            }else
            {
                l++;
            }
        }

        return max;
    }
}
