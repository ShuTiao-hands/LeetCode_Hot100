public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        //快慢指针
        int low = 0;
        int fast = 1;
        int temp = 0;
        while(fast < nums.Length)
        {
            if (nums[low] == 0)
            {
                if (nums[fast] != 0)
                {
                    temp = nums[low];
                    nums[low] = nums[fast];
                    nums[fast] = temp;
                }
                else
                {
                    fast++;
                }
            }
            else if(low < fast - 1)
            {
                low++;
            }
            else
            {
                fast++;
            }
        }
    }
}