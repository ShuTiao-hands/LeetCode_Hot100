public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;                   // 记录最大面积
        int left = 0;                      // 左指针从数组头开始
        int right = height.Length - 1;     // 右指针从数组尾开始

        while (left < right)
        {             // 左右指针未相遇时循环
            int currentHeight = Math.Min(height[left], height[right]);  // 取较矮的高度
            int width = right - left;     // 计算间距
            maxArea = Math.Max(maxArea, currentHeight * width);  // 更新最大面积

            if (height[left] < height[right])
            {
                left++;                   // 移动较矮的左指针，试图找到更高的左边界
            }
            else
            {
                right--;                  // 移动较矮的右指针，试图找到更高的右边界
            }
        }

        return maxArea;                   // 返回最终结果


    }
}