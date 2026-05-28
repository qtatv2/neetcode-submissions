public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0;
        int r = matrix.Length - 1;
        while(l<=r)
        {
            int mid = (l + r)/2;
            int l2 = 0;
            int r2 = matrix[mid].Length - 1;
            int mid2 = (l2 + r2)/2;
            while(l2<=r2)
            {
                mid2 = (l2 + r2)/2;
                if(matrix[mid][mid2] == target)
                {
                    return true;
                }else if(target>matrix[mid][mid2])
                {
                    l2 = mid2 + 1;
  
                }else
                {
                    r2 = mid2 - 1;

                }
            }
            if(matrix[mid][mid2]<target)
            {
                l = mid + 1;
            }else if(matrix[mid][mid2]>target)
            {
                r = mid - 1;
            }
        }
        return false;
    }
}
