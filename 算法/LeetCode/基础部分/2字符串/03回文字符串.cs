using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
    说明：本题中，我们将空字符串定义为有效的回文串。

    示例 1:
    输入: "A man, a plan, a canal: Panama"
    输出: true

    示例 2:
    输入: "race a car"
    输出: false
*/
namespace 基础部分
{
    class _23回文字符串
    {
        static void Main(string[] args)
        {
            _23回文字符串 c = new _23回文字符串();
            Console.WriteLine(c.IsPalindrome("race a car"));
        }
        public bool IsPalindrome(string s)
        {
            if (s.Length <= 1 || s == " ")
                return true;
            s = s.ToLower();

            for (int i = 0, j = s.Length - 1; i < j;)
            {
                if (valid(s[i]))
                {
                    if (valid(s[j]))
                    {
                        if (s[i] != s[j])
                            return false;
                        else
                        {
                            i++;
                            j--;
                        }
                    }
                    else
                    {
                        j--;
                    }
                }
                else
                {
                    i++;
                }
            }
            return true;
        }
        public bool valid(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                return true;
            return false;
        }
    }
}
