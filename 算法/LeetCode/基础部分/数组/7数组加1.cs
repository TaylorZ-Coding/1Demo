using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
    最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。
    你可以假设除了整数 0 之外，这个整数不会以零开头。

    示例 1:
    输入: [1,2,3]
    输出: [1,2,4]
    
    解释: 输入数组表示数字 123。

    示例 2:
    输入: [4,3,2,1]
    输出: [4,3,2,2]

    解释: 输入数组表示数字 4321。
*/
namespace 基础部分
{

    class _7数组加1
    {
        static void Main(string[] args)
        {
            int[] digits = { 1, 9, 9, 9 };
            _7数组加1 c = new _7数组加1();
            var dig = c.PlusOne(digits);
        }

        public int[] PlusOne(int[] digits)
        {
            int len = digits.Length;

            //1:直接尾部加一
            if (digits[len - 1] != 9)
            {
                digits[len - 1] += 1;
                return digits;
            }

            //2:9999这种，数组长度加一，首位为1，其余都为0
            bool needAddLen = true;//如果是9999这种，数组长度增加加一
            foreach (var i in digits)
            {
                if (i != 9)
                    needAddLen = false;
            }
            if (needAddLen)
            {
                int[] newDig = new int[len + 1];
                newDig[0] = 1;
                return newDig;

            }

            //3:有进位但不增加数组长度的，2309、3999等
            else
            {
                for (int i = len - 1; i >= 0; i--)
                {

                    if (digits[i] != 9)
                    {
                        digits[i] += 1;
                        return digits;
                    }
                    else
                    {
                        digits[i] = 0;
                    }
                }
            }

            return digits;
        }
    }
}
