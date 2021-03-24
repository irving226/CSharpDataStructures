using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArrayofSunshine.OneThreeEightZero;

namespace ArrayofSunshine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1, 10, 4, 2 };
            matrix[1] = new int[4] { 9, 3, 8, 7 };
            matrix[2] = new int[4] { 15, 16, 17, 12 };
            OneThreeEightZero ln = new OneThreeEightZero();
            ln.LuckyNumbers(matrix);

        }
    }
}
