namespace OneQuestionPerDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Solution20211031
    {
        /// <summary>
        /// 500. 键盘行.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string[] FindWords(string[] words)
        {
            string[] keybords = new string[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            List<string> ans = new List<string>();
            int n = words.Length;
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (keybords[j].Contains(char.ToLower(words[i][0])))
                    {
                        temp[i] = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                bool b = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!keybords[temp[i]].Contains(char.ToLower(words[i][j])))
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    ans.Add(words[i]);
                }
            }
            return ans.ToArray();
        }
    }
}
