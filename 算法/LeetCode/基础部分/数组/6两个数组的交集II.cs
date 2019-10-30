using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定两个数组，编写一个函数来计算它们的交集。

    示例 1:
    输入: nums1 = [1,2,2,1], nums2 = [2,2]
    输出: [2,2]

    示例 2:
    输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
    输出: [4,9]
    
    说明：
    输出结果中每个元素出现的次数，应与元素在两个数组中出现的次数一致。
    我们可以不考虑输出结果的顺序。

    进阶:
    如果给定的数组已经排好序呢？你将如何优化你的算法？
    如果 nums1 的大小比 nums2 小很多，哪种方法更优？
    如果 nums2 的元素存储在磁盘上，磁盘内存是有限的，并且你不能一次加载所有的元素到内存中，你该怎么办？
 */

namespace 基础部分
{
    class _6两个数组的交集II
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            //int[] nums1 = { 1 };
            //int[] nums2 = { 1, 2 };

            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = {  2, 2};

            _6两个数组的交集II c = new _6两个数组的交集II();
            var nums = c.Intersect(nums1, nums2);
            foreach (var i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();
        }


        /*
         * [4,5,9]
         * [4,4,8,9,9]
         */
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            //保证nums1比nums2小
            if (nums1.Length > nums2.Length)
            {
                var temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }
            Array.Sort(nums1);
            Array.Sort(nums2);

            List<int> nums = new List<int>();


            int len1 = nums1.Length;
            int len2 = nums2.Length;


            for (int i = 0, j = 0; i < len1 && j < len2;)
            {
                if (nums1[i] == nums2[j])
                {
                    nums.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }





            int[] newNums = new int[nums.Count];
            for (int i = 0; i < nums.Count; i++)
            {
                newNums[i] = nums[i];
            }

            return newNums;
        }
    }
}
