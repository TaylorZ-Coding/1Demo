using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。

    说明：
    你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？

    示例 1:
    输入: [2,2,1]
    输出: 1
    
    示例 2:
    输入: [4,1,2,1,2]
    输出: 4
*/

namespace 基础部分
{
    class _5只出现一次的数字
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 56, 68, 43, 56, 68 };
            _5只出现一次的数字 c = new _5只出现一次的数字();
            Console.WriteLine(c.SingleNumber(nums));
        }
        public int SingleNumber(int[] nums)
        {

            Array.Sort(nums);
            if (nums.Length == 1)
                return nums[0];
            if (nums[0] != nums[1])
                return nums[0];
            if (nums[nums.Length - 1] != nums[nums.Length - 2])
                return nums[nums.Length - 1];



            for (int i = 1; i < nums.Length - 1; i++)
                if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
                    return nums[i];

            return 0;
        }
    }
}
