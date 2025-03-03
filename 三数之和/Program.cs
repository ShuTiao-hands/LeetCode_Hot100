public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums); // 第一步：将数组排序（从小到大）
        List<IList<int>> result = new List<IList<int>>(); // 存储最终结果的列表

        // 外层循环：固定第一个数 nums[i]
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // 跳过重复的 i（避免重复三元组）
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            // 定义双指针：左指针从 i+1 开始，右指针从末尾开始
            int left = i + 1, right = nums.Length - 1;

            // 内层循环：双指针寻找剩下的两个数
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    // 找到符合条件的三元组
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // 跳过重复的 left 和 right
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    // 移动指针继续寻找其他可能的组合
                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    // 和太小，左指针右移（增大和）
                    left++;
                }
                else
                {
                    // 和太大，右指针左移（减小和）
                    right--;
                }
            }
        }
        return result; // 返回结果

    }
}