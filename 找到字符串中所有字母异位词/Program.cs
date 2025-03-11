public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> result = new List<int>();
        int sLen = s.Length, pLen = p.Length;
        if (pLen > sLen) return result;

        int[] pCount = new int[26];  // p的字符频率
        int[] sCount = new int[26];  // 窗口的字符频率

        // 统计p的字符
        foreach (char c in p)
        {
            pCount[c - 'a']++;//-‘a’ = -97，因为数组用-ASCII码的偏移量来记录索引
        }

        // 初始化第一个窗口的字符
        for (int i = 0; i < pLen; i++)
        {
            sCount[s[i] - 'a']++;
        }

        // 检查初始窗口
        if (AreArraysEqual(pCount, sCount))
        {
            result.Add(0);
        }

        // 滑动窗口
        for (int i = 1; i <= sLen - pLen; i++)
        {
            // 移除左边界的旧字符
            sCount[s[i - 1] - 'a']--;  // 左边界的索引是 i-1
            // 添加右边的新字符
            sCount[s[i + pLen - 1] - 'a']++;  // 新右边界的索引是 i+pLen-1

            // 检查当前窗口是否匹配
            if (AreArraysEqual(pCount, sCount))
            {
                result.Add(i);
            }
        }

        return result;

    }

    // 手动比较两个数组是否相等
    private bool AreArraysEqual(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i]) return false;
        }
        return true;
    }
}