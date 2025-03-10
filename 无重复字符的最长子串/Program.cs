public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxNum = 0;
        int left = 0;
        Dictionary<char, int> charDic = new Dictionary<char, int>();
        for (int right = 0; right < s.Length; right++)
        {
            if (charDic.ContainsKey(s[right]))
            {
                left = Math.Max(left, charDic[s[right]] + 1);
            }
            charDic[s[right]] = right;
            maxNum = Math.Max(maxNum, right - left + 1);
        }
        return maxNum;



    }
}
