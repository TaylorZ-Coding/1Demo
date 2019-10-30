using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    给定一个 n × n 的二维矩阵表示一个图像。
    将图像顺时针旋转 90 度。

    说明：
    你必须在原地旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要使用另一个矩阵来旋转图像。

    示例 1:

    给定 matrix = 
    [
        [1,2,3],
        [4,5,6],
        [7,8,9]
    ],

    原地旋转输入矩阵，使其变为:
    [
        [7,4,1],
        [8,5,2],
        [9,6,3]
    ]

    示例 2:

    给定 matrix =
    [
        [ 5, 1, 9,11],
        [ 2, 4, 8,10],
        [13, 3, 6, 7],
        [15,14,12,16]
    ], 

    原地旋转输入矩阵，使其变为:
    [
        [15,13, 2, 5],
        [14, 3, 4, 1],
        [12, 6, 8, 9],
        [16, 7,10,11]
    ]
*/

namespace 基础部分
{
    class _11旋转图像
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][]{
                new int[]{15, 13, 2, 5 },
                new int[] {14, 3, 4, 1 },
                new int[] {12, 6, 8, 9 },
                new int[] {16, 7, 10, 11 }
            };

            _11旋转图像 c = new _11旋转图像();
            c.Rotate(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)//行、列一样
                {
                    Console.Write(matrix[i][j] + ", ");
                }
                Console.WriteLine("\b\b ");


            }
        }
        public void Rotate(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix.Length;
            for (int top = 0, right = col - 1, bottom = row - 1, left = 0; left < right && top < bottom; top++, bottom--, right--, left++)
            {
                RotateExternal(matrix, top, right, bottom, left);

            }
        }

        //将matrix的外部元素旋转
        public void RotateExternal(int[][] matrix, int top, int right, int bottom, int left)
        {
            //当前需要每次移动（比如移动top）的元素的个数
            int len = right - left;
            int[] temp = new int[len];

            //1: right=>temp   top=>right
            for (int i = 0; i < len; i++)
            {

                temp[i] = matrix[i + top][right];

                matrix[i + top][right] = matrix[top][i + top];

            }
            //2:  bottom=>top  temp=>bottom
            for (int i = 0; i < len; i++)
            {
                matrix[top][i + top] = matrix[bottom][right - i];
                matrix[bottom][right - i] = temp[i];
            }
            //3:  left=>temp  top=>left
            for (int i = 0; i < len; i++)
            {
                temp[i] = matrix[bottom - i][left];
                matrix[bottom - i][left] = matrix[top][i + top];
            }
            //4:  temp=>top
            for (int i = 0; i < len; i++)
            {
                matrix[top][i + top] = temp[i];
            }

        }
    }
}
