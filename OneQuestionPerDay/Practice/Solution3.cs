namespace Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution3
    {
        /// <summary>
        /// 3. 无重复字符的最长子串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            if (n <= 1)
            {
                return n;
            }
            int ans = 1;
            int i = 1;
            Queue<char> queue = new Queue<char>();
            queue.Enqueue(s[0]);
            while (i < n)
            {
                if (queue.Contains(s[i]))
                {
                    ans = Math.Max(ans, queue.Count);
                    while (queue.Dequeue() == s[i])
                    {
                        queue.Enqueue(s[i]);
                        i++;
                        break;
                    }
                }
                else
                {
                    queue.Enqueue(s[i]);
                    i++;
                }
            }
            return Math.Max(ans, queue.Count);
        }
    }
}
