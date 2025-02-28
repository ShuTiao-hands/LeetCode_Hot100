public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> mp = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            char[] keyChars = str.ToCharArray(); // 把"eat"拆成 ['e','a','t']
            Array.Sort(keyChars); // 排序成 ['a','e','t']
            string key = new string(keyChars); // 合并成 "aet"
            if (!mp.ContainsKey(key)) // 检查柜子有没有这个标签的抽屉
            {
                mp[key] = new List<string>(); // 没有就新增一个抽屉和空盒子
            }
            mp[key].Add(str); // 把单词放进对应抽屉的盒子里
        }
        return new List<IList<string>>(mp.Values); //mp.Values会返回一个集合包含这个字典中的值

    }
}