namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution20211101
    {
        /// <summary>
        /// 575. 分糖果.
        /// </summary>
        /// <param name="candyType"></param>
        /// <returns></returns>
        public int DistributeCandies(int[] candyType)
        {
            HashSet<int> hs = new HashSet<int>();
            int n = candyType.Length;
            for (int i = 0; i < n; i++)
            {
                hs.Add(candyType[i]);
                if (hs.Count == n>>1)
                {
                    return hs.Count;
                }
            }
            return hs.Count;
        }
    }
}
