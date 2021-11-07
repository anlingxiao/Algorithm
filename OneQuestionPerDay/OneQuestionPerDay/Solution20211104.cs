namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Solution20211104
    {
        /// <summary>
        /// 367. 有效的完全平方数.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsPerfectSquare(int num)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int i = 1;
            while ((long)i * (long)i <= int.MaxValue)
            {
                dic.Add(i, i * i);
                i++;
            }

            return dic.ContainsValue(num);
        }
    }
}
