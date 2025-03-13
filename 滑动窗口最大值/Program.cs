public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var ans = new int[nums.Length - k + 1];
        // 优先级队列
        PriorityQueue<int, int> pq = new();
        // 准备第一个窗口，除最后一个元素未进入队列
        for (int i = 0; i < k - 1; i++)
            pq.Enqueue(i, -nums[i]);
        // 移动窗口，i是右边界
        for (int i = k - 1; i < nums.Length; i++)
        {
            // 元素加入队列
            pq.Enqueue(i, -nums[i]);
            // 队头元素索引不在当前滑动窗口范围内，需要移除。
            while (pq.Peek() < i - k + 1)
                pq.Dequeue();
            // 取得当前窗口最大值
            ans[i - k + 1] = nums[pq.Peek()];
        }
        return ans;


    }

}
