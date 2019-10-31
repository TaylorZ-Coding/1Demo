using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个整数数组，判断是否存在重复元素。
    如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。

    示例 1:
    输入: [1,2,3,1]
    输出: true

    示例 2:
    输入: [1,2,3,4]
    输出: false
    
    示例 3:
    输入: [1,1,1,3,3,4,3,2,4,2]
    输出: true
 */

namespace 基础部分
{
    class _4判断数组是否存在重复
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 7, 78, 57, 3, 5, 7, 7, 7 };
            _4判断数组是否存在重复 c = new _4判断数组是否存在重复();
            bool r = c.ContainsDuplicate(nums);

            foreach (var i in nums)
                Console.Write(i + " ");
            Console.WriteLine(r);


        }
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length < 2)
                return false;
            Array.Sort(nums);//改用Array.Sort就通过了

            for (int i = 0; i < nums.Length - 1; i++)
                if (nums[i] == nums[i + 1])
                    return true;

            return false;
        }



    }
}
