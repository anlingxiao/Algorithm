namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Solution20211105
    {
        /// <summary>
        /// 1218. 最长定差子序列.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="difference"></param>
        /// <returns></returns>
        public int LongestSubsequence(int[] arr, int difference)
        {
            int ans = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                int p = dic.ContainsKey(i - difference) ? dic[i - difference] : 0;
                if (dic.ContainsKey(i))
                {
                    dic[i] = p + 1;
                }
                else
                {
                    dic.Add(i, p + 1);
                }
                ans = Math.Max(ans, dic[i]);
            }
            return ans;
        }
    }
}
