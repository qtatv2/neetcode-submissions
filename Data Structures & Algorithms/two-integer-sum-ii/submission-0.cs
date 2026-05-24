public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r  = numbers.Length-1;
        while(l<=r)
        {
            while(numbers[l]+numbers[r]>target && l<r)
            {
                r--;
            }
            while(numbers[l]+numbers[r]<target && l<r)
            {
                l++;
            }
            if(numbers[l]+numbers[r]==target)
            {
                return [l+1,r+1];
            }
        }
        return [0,0];
    }
}
