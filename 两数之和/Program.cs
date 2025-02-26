

//答题模板
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {

//    }
//}

//靠自己想的暴力遍历
//用两个for循环去遍历，找到相加为对应值的就返回，本质是双指针
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] array = new int[2];
//        for (int i = 0; i < nums.Length; i++) 
//        {
//            for (int j = i + 1; j < nums.Length; j++) //i从下标0开始遍历，j从下标1开始遍历
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    array[0] = i;
//                    array[1] = j;
//                    return array;
//                }                
//            }
//        }
//        return array;//没有就返回一个空数组
//    }
//}


//字典解法 

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))  // 当前值是否是需要被加数？
            {
                return new int[] { dic[nums[i]], i };  // 返回[被加数索引, 当前索引]
            }

            // 将当前数作为被加数需要的加数存入字典
            dic[target - nums[i]] = i;  // 使用索引器避免重复键异常
        }
        return new int[2]; // 实际不会执行到这里
    }
}