public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r  = numbers.Length-1;
        while(l<r)
        {
            if(numbers[l]+numbers[r]>target)
            {
                r--;
            }
            if(numbers[l]+numbers[r]<target)
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
