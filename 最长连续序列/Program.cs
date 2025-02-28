public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);//声明一个hashset容器，自动去重，声明为int类型避免装箱拆箱
        int longest = 0;//最连续序列计数
        foreach (int num in set) //遍历hashset
        {
            if (set.Contains(num - 1)) continue;//如果能找到比它小1的数，跳过，说明它不是起点
            int currentNum = num;//记录起点
            int currentStreak = 0;//记录序列长度
            while (set.Contains(currentNum))
            {
                currentStreak++;
                currentNum++;
            }
            longest = Math.Max(longest, currentStreak);//比较当前和已记录的，保留更大的
        }
        return longest;
    }
}