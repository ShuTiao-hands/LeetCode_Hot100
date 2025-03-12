public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        //纯暴力，没有技巧，全是暴力
        //int sumMax = 0;
        //for (int i = 0; i < nums.Length; i++) 
        //{
        //    int sum = 0;
        //    for(int j = i; j < nums.Length; j++)
        //    {
        //        sum += nums[j];
        //        if(sum == k)
        //        {
        //            sumMax++;
        //        }
        //    }
        //}
        //return sumMax;

        //前缀和，计算所有字符一个个加起来，再减去目标值
        int sum = 0;
        int result = 0;
        Dictionary<int,int> sumDic = new Dictionary<int,int>();
        sumDic[0] = 1;
        foreach(int i in nums)
        {
            sum += i;
            int target = sum - k;
            if(sumDic.TryGetValue(target,out int count))
            {
                result += count;
            }
            sumDic[sum] = sumDic.GetValueOrDefault(sum, 0) + 1;
        }
        return result;
    }
}