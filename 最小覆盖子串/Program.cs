public class Solution
{
    public string MinWindow(string s, string t)
    {
        // 统计 t 中每个字符需要的数量
        Dictionary<char, int> targetCounts = new Dictionary<char, int>();
        foreach (char c in t)
        {
            targetCounts[c] = targetCounts.GetValueOrDefault(c, 0) + 1;
        }

        Dictionary<char, int> currentWindow = new Dictionary<char, int>();
        int left = 0, right = 0;
        int matchedChars = 0; // 已满足数量的字符种类数

        int minStart = 0;     // 最小窗口的起始位置
        int minLength = int.MaxValue; // 最小窗口的长度

        while (right < s.Length)
        {
            // 步骤1：扩大右边界，收集字符
            char rightChar = s[right];
            right++;

            // 只处理在 targetCounts 中出现的字符
            if (targetCounts.ContainsKey(rightChar))
            {
                currentWindow[rightChar] = currentWindow.GetValueOrDefault(rightChar, 0) + 1;

                // 当某个字符的数量刚好满足需求时，增加匹配计数
                if (currentWindow[rightChar] == targetCounts[rightChar])
                {
                    matchedChars++;
                }
            }

            // 步骤2：当窗口满足条件时，尝试收缩左边界
            while (matchedChars == targetCounts.Count)
            {
                // 更新最小窗口记录
                if (right - left < minLength)
                {
                    minStart = left;
                    minLength = right - left;
                }

                // 移动左边界
                char leftChar = s[left];
                left++;

                if (targetCounts.ContainsKey(leftChar))
                {
                    // 如果移出的字符导致数量不满足，减少匹配计数
                    if (currentWindow[leftChar] == targetCounts[leftChar])
                    {
                        matchedChars--;
                    }
                    currentWindow[leftChar]--;
                }
            }
        }

        // 返回结果（如果未找到返回空字符串）
        return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);




    }
}