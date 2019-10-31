using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。

    案例:
    s = "leetcode"
    返回 0.
    s = "loveleetcode",
    返回 2.
 
    注意事项：您可以假定该字符串只包含小写字母。
*/

namespace 基础部分
{
    class _21字符串第一个唯一字符
    {
        static void Main(string[] args)
        {
            _21字符串第一个唯一字符 c = new _21字符串第一个唯一字符();
            string s = "loveleetcode";
            Console.WriteLine(c.FirstUniqChar(s));
        }
        public int FirstUniqChar(string s)
        {
            //key store char, value store count
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], 1);
                }

            }

            //keyList store chars of number 1
            List<char> keyList = new List<char>();
            foreach (var i in dic)
            {
                if (i.Value > 1)
                    continue;
                else
                    keyList.Add(i.Key);
            }

            if (keyList.Count < 1)
                return -1;

            //store index for char
            List<int> indexList = new List<int>();
            foreach (var i in keyList)
            {
                indexList.Add(s.IndexOf(i));
            }
            //return the smallest index
            return indexList.Min();

        }

    }
}
