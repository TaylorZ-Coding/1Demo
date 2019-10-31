using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    编写一个函数来查找字符串数组中的最长公共前缀。
    如果不存在公共前缀，返回空字符串 ""。

    示例 1:
    输入: ["flower","flow","flight"]
    输出: "fl"

    示例 2:
    输入: ["dog","racecar","car"]
    输出: ""
    解释: 输入不存在公共前缀。

    说明:
    所有输入只包含小写字母 a-z 。
 */
namespace 基础部分
{
    class _27最长公共前缀
    {
        static void Main(string[] args)
        {
            _27最长公共前缀 c = new _27最长公共前缀();
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine(c.LongestCommonPrefix(strs));
          
        }
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 2)
                return strs[0];

            //得到所有字符串中最小长度
            int minLen = strs[0].Length;
           for(int i=1;i<strs.Length;i++)
           {
                if (strs[i].Length < minLen)
                    minLen = strs[i].Length;
            }

           string res = "";
           bool valid = true;
           for(int i=0;i<minLen;i++)
           {
                for(int j=1;j<strs.Length;j++)
                {
                    if (strs[j][i] != strs[0][i])
                    {
                        valid = false;
                        break;
                    }
                    
                }
                if (valid)
                    res=res.Insert(res.Length, strs[0][i].ToString());
                else
                    break;
            }
           
            return res;
        }
        
    }
}
