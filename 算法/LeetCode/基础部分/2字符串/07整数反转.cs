using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

    示例 1:
    输入: 123
    输出: 321

    示例 2:
    输入: -123
    输出: -321

    示例 3:
    输入: 120
    输出: 21

    注意:
    假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。
 */
namespace 基础部分
{
    class _20整数反转
    {

        static void Main(string[] args)
        {
            int x = -123;
            _20整数反转 c = new _20整数反转();

            Console.WriteLine(c.Reverse(x));
        }
        public int Reverse(int x)
        {
            StringBuilder s;
            bool lessZero = false;
            if (x < 0)
            {
                s = new StringBuilder(x.ToString().Substring(1));
                lessZero = true;
            }

            else
                s = new StringBuilder(x.ToString());

            char temp;
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            string str = s.ToString();

            try
            {
                x = Convert.ToInt32(str);
            }
            catch (Exception)
            {
                return 0;
            }

            if (lessZero)
                return -x;
            return x;
        }
    }


}
