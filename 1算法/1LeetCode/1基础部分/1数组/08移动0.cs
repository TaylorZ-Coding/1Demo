using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  
    给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

    示例:
    输入: [0,1,0,3,12]
    输出: [1,3,12,0,0]
    
    说明:
    必须在原数组上操作，不能拷贝额外的数组。
    尽量减少操作次数。
*/
namespace 基础部分
{
    class _8移动0
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            _8移动0 c = new _8移动0();
            c.MoveZeroes(nums);

            foreach (var i in nums)
                Console.Write(i + " ");
            Console.WriteLine();

        }

        public void MoveZeroes(int[] nums)
        {
            //记录每个0的位置
            List<int> posZero = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    posZero.Add(i);
                else
                {
                    if (posZero.Count == 0)
                        continue;
                    else
                    {
                        //前面0的个数即posZero的元素个数
                        nums[i - posZero.Count] = nums[i];
                    }
                }
            }

            for (int i = 0; i < posZero.Count; i++)
            {
                nums[nums.Length - 1 - i] = 0;
            }


        }
    }
}
