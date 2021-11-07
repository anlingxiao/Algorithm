namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Solution20211107
    {
        /// <summary>
        /// 598. 范围求和 II.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        public int MaxCount(int m, int n, int[][] ops)
        {
            foreach (var item in ops)
            {
                m = Math.Min(m, item[0]);
                n = Math.Min(n, item[1]);
            }
            return m * n;
        }
    }
}
