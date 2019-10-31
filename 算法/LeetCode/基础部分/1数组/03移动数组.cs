using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。

    示例 1:
    输入: [1,2,3,4,5,6,7] 和 k = 3
    输出: [5,6,7,1,2,3,4

    解释:
    向右移动 1 步: [7,1,2,3,4,5,6]
    向右移动 2 步: [6,7,1,2,3,4,5]
    向右移动 3 步: [5,6,7,1,2,3,4]

    示例 2:
    输入: [-1,-100,3,99] 和 k = 2
    输出: [3,99,-1,-100]

    解释: 
    向右移动 1 步: [99,-1,-100,3]
    向右移动 2 步: [3,99,-1,-100]

    说明:
    尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
    要求使用空间复杂度为 O(1) 的 原地 算法。
*/
namespace 基础部分
{
    class _3移动数组
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int k = 1;

            _3移动数组 c = new _3移动数组();
            c.Rotate(nums, k);
            foreach (var i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //将数组下标start到end的元素反转，比如12345反转为54321
        public void reverse(int[] nums, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }

        /*
         * 1 2 3 4 5 6   k=2
         * 4 3 2 1 6 5
         * 5 6 1 2 3 4
        */
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length < 2)
                return;
            k = k % nums.Length;

            reverse(nums, 0, nums.Length - k - 1);
            reverse(nums, nums.Length - k, nums.Length - 1);
            reverse(nums, 0, nums.Length - 1);

        }
    }
}

