using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
    不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。

    示例 1:
    给定数组 nums = [1,1,2], 
    函数应该返回新的长度 2, 并且原数组 nums 的前两个元素被修改为 1, 2。 
    你不需要考虑数组中超出新长度后面的元素。

    示例 2:
    给定 nums = [0,0,1,1,1,2,2,3,3,4],
    函数应该返回新的长度 5, 并且原数组 nums 的前五个元素被修改为 0, 1, 2, 3, 4。

    你不需要考虑数组中超出新长度后面的元素。
 */
namespace 基础部分
{
    class _1删除排序数组中重复项
    {
        static void Main(string[] args)
        {
            int[] nums = null;
            string s = Console.ReadLine();
            s = s.Remove(0, 1);
            s = s.Remove(s.Length - 1, 1);

            string[] temp = s.Split(',');

            nums = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                nums[i] = Convert.ToInt32(temp[i]);
            }

            int len = RemoveDuplicates(nums);

            //foreach (var i in nums)
            //{

            //    Console.Write($"{i} ");
            //}


            Console.WriteLine(len);
        }

        public static int RemoveDuplicates(int[] nums)
        {

            //要考虑各种测试用例，长度为0的或为1的（直接返回数组长度即可，不用操作）和大于1的
            if (nums.Length < 2)
                return nums.Length;

            int len = 1;//新数组初始长度为1
            int n = nums[0];//当前元素为n，初始为数组第一个元素

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {

                }
                else
                {
                    nums[len] = nums[i];
                    len++;
                    n = nums[i];
                }
            }


            return len;
        }
    }



}
