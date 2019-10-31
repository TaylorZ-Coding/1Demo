using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定两个字符串 s 和 t ，编写一个函数来判断 t 是否是 s 的字母异位词(即仅仅顺序不同)。

    示例 1:
    输入: s = "anagram", t = "nagaram"
    输出: true

    示例 2:
    输入: s = "rat", t = "car"
    输出: false

    说明:
    你可以假设字符串只包含小写字母。

    进阶:
    如果输入字符串包含 unicode 字符怎么办？你能否调整你的解法来应对这种情况？
    */
namespace 基础部分
{
    class _22字母异位词
    {
        static void Main(string[] args)
        {
            //string s = "anagram";
            //string t = "nagaram";
            string s = "anagram";
            string t = "nagaram";
            _22字母异位词 c = new _22字母异位词();
            Console.WriteLine(c.IsAnagram(s, t));
        }
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            Dictionary<char, int> dicS = new Dictionary<char, int>();
            Dictionary<char, int> dicT = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dicS.ContainsKey(s[i]))
                {
                    dicS[s[i]]++;
                }
                else
                {
                    dicS.Add(s[i], 1);
                }

                if (dicT.ContainsKey(t[i]))
                {
                    dicT[t[i]]++;
                }
                else
                {
                    dicT.Add(t[i], 1);
                }
            }

            if (dicT.Count != dicS.Count)
                return false;
            foreach (var i in dicS)
            {
                if (!dicT.Contains(i))
                    return false;
            }

            return true;
        }
    }
}
