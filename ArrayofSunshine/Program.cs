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
            int[][] matrix = new int[5][];
            matrix[0] = new int[5] { 5,6,2,1,6};
            matrix[1] = new int[5] { 6,3,2,5,1 };
            matrix[2] = new int[5] { 7,5,7,7,2 };
            matrix[3]=  new int[4] { 1,9,4,5};
            matrix[4] = new int[5] { 2, 7, 0, 1, 4 };
            OneThreeEightZero ln = new OneThreeEightZero();
            ln.LuckyNumbers(matrix);

        }
    }
}
