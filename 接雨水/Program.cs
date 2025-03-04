public class Solution
{
    public int Trap(int[] height)
    {
        //至少有三个柱子才能存水，柱子与柱子中间是没有缝隙的
        if (height == null || height.Length < 3) return 0;

        int left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];
        int ans = 0;

        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                //最大的柱子减去当前的柱子高度，代表着当前可以存水的数量
                leftMax = Math.Max(leftMax, height[left]);
                ans += leftMax - height[left];
            }
            else
            {
                right--;
                ////最大的柱子减去当前的柱子高度，代表着当前可以存水的数量
                rightMax = Math.Max(rightMax, height[right]);
                ans += rightMax - height[right];
            }
        }
        return ans;


    }
}