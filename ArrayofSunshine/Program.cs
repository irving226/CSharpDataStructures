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
            matrix[0] = new int[3] { 3, 7, 8 };
            matrix[1] = new int[3] { 9, 11, 13 };
            matrix[2] = new int[3] { 15, 16, 17 };
            OneThreeEightZero ln = new OneThreeEightZero();
            ln.LuckyNumbers(matrix);

        }
    }
}
