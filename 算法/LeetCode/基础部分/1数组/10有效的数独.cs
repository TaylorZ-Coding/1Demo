using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    判断一个 9x9 的数独是否有效。只需要根据以下规则，验证已经填入的数字是否有效即可。

    数字 1-9 在每一行只能出现一次。
    数字 1-9 在每一列只能出现一次。
    数字 1-9 在每一个以粗实线分隔的 3x3 宫内只能出现一次。

    数独部分空格内已填入了数字，空白格用 '.' 表示。

    示例 1:
    输入:
    [
        ["5","3",".",".","7",".",".",".","."],
        ["6",".",".","1","9","5",".",".","."],
        [".","9","8",".",".",".",".","6","."],
        ["8",".",".",".","6",".",".",".","3"],
        ["4",".",".","8",".","3",".",".","1"],
        ["7",".",".",".","2",".",".",".","6"],
        [".","6",".",".",".",".","2","8","."],
        [".",".",".","4","1","9",".",".","5"],
        [".",".",".",".","8",".",".","7","9"]
    ]
    输出: true

    示例 2:
    输入:
    [
        ["8","3",".",".","7",".",".",".","."],
        ["6",".",".","1","9","5",".",".","."],
        [".","9","8",".",".",".",".","6","."],
        ["8",".",".",".","6",".",".",".","3"],
        ["4",".",".","8",".","3",".",".","1"],
        ["7",".",".",".","2",".",".",".","6"],
        [".","6",".",".",".",".","2","8","."],
        [".",".",".","4","1","9",".",".","5"],
        [".",".",".",".","8",".",".","7","9"]
    ]
    输出: false

    解释: 除了第一行的第一个数字从 5 改为 8 以外，空格内其他数字均与 示例1 相同。
    但由于位于左上角的 3x3 宫内有两个 8 存在, 因此这个数独是无效的。

    说明:
    一个有效的数独（部分已被填充）不一定是可解的。
    只需要根据以上规则，验证已经填入的数字是否有效即可。
    给定数独序列只包含数字 1-9 和字符 '.' 。
    给定数独永远是 9x9 形式的。
*/

namespace Solution
{
    class _10有效的数独
    {
        static void Main(string[] args)
        {
            //char[][] board = new char[9][]{
            //    new char[]{ '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            //    new char[]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            //    new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            //    new char[]{ '8', '.', '.', '.', '6', '.', '.', '.', '3'},
            //    new char[]{ '4', '.', '.', '8', '.', '3', '.', '.', '1'},
            //    new char[]{  '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            //    new char[]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            //    new char[]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            //    new char[]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            //};


            char[][] board = new char[9][]{
                new char[]{ '.', '.', '.', '.', '5', '.', '.', '1', '.' },
                new char[]{ '.', '4', '.', '3', '.', '.', '.', '.', '.' },
                new char[]{'.', '.', '.', '.', '.', '3', '.', '.', '1'},

                new char[]{ '8', '.', '.', '.', '.', '.', '.', '2', '.'},
                new char[]{ '.', '.', '2', '.', '7', '.', '.', '.', '.'},
                new char[]{ '.', '1', '5', '.', '.', '.', '.', '.', '.' },

                new char[]{  '.', '.', '.', '.', '.', '2', '.', '.', '.' },
                new char[]{ '.', '2', '.', '9', '.', '.', '.', '.', '.' },
                new char[]{ '.', '.', '4', '.', '.', '.', '.', '.', '.' }
            };






            _10有效的数独 c = new _10有效的数独();

            Console.WriteLine(c.IsValidSudoku(board));
        }

        public bool RowInvalid(char[][] board, int row)
        {

            List<char> list = new List<char>();
            for (int j = 0; j < board[row].Length; j++)
            {
                char c = board[row][j];
                if (list.Contains(c))
                    return true;
                else
                {
                    if (c != '.')
                        list.Add(c);
                }

            }

            list = null;
            return false;
        }
        public bool ColInvalid(char[][] board, int col)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < board.Length; i++)
            {
                char c = board[i][col];
                if (list.Contains(c))
                    return true;
                else
                {
                    if (c != '.')
                        list.Add(c);
                }

            }
            list = null;
            return false;
        }

        //第row大行,col大列的块,都从0开始
        public bool BlockInvalid(char[][] board, int row, int col)
        {
            int rowStart, colStart, rowEnd, colEnd;
            rowStart = row * 3;
            rowEnd = row * 3 + 2;
            colStart = col * 3;
            colEnd = col * 3 + 2;


            List<char> list = new List<char>();
            for (int i = rowStart; i <= rowEnd; i++)
            {

                for (int j = colStart; j <= colEnd; j++)
                {
                    char c = board[i][j];
                    if (list.Contains(c))
                        return true;
                    else
                    {
                        if (c != '.')
                            list.Add(c);
                    }
                }

            }
            list = null;
            return false;
        }

        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (RowInvalid(board, i))
                    return false;
            }
            for (int j = 0; j < board[0].Length; j++)
            {
                if (ColInvalid(board, j))
                    return false;
            }
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (BlockInvalid(board, i, j))
                        return false;
                }
            return true;
        }
    }

}

