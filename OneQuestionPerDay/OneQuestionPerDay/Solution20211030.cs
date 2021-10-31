namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution20211030
    {
        /// <summary>
        /// 260. 只出现一次的数字 III
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SingleNumber(int[] nums)
        {
            int n = nums.Length;
            if (n == 2)
            {
                return nums;
            }

            IList<int> ans = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }

            foreach (var item in dic)
            {
                if (item.Value == 1)
                {
                    ans.Add(item.Key);
                }
            }
            return ans.ToArray();
        }
    }
}
