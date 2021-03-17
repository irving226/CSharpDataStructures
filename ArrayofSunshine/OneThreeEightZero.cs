using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofSunshine
{
    class OneThreeEightZero
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            //iterate thru x, when you get a num
            //hold on to it(?) and compare it to the other nums in the Y coloumn
            //return whichever is 
            List<int> test = new List<int>();
          
           
          
            bool searching = true;

            while (searching)
            {
                int max = matrix[0][0];
                int xLocator = 0;
                int yLocator = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 1; j < matrix.Length; j++)
                    {
                        test.Add(matrix[i][j]);
                    }

                }
    //
    //        //now that we've found the biggest int we need to figure out if its the smallest in the row
    //        foreach(int num in matrix[yLocator])
    //        {
    //            //if true then this num isn't lucky, zero it out
    //            if (num < max)
    //            {
    //                matrix[xLocator][yLocator] = 0;
    //            }
    //            else
    //            {
    //                searching = true;
    //                int luckyNumber = max;
    //                test.Add(max);
    //            }   
    //        }
    //    }

            return test;

        }

    }
}
    }

////Given a m * n matrix of distinct numbers, return all lucky numbers in the matrix in any order.
//
//A lucky number is an element of the matrix such that it is the minimum element in its row and maximum in its column.
//
// 
//
//Example 1:
//
//Input: matrix = [[3, 7, 8],[9,11,13],[15,16,17]]
//Output:[15]
//Explanation: 15 is the only lucky number since it is the minimum in its row and the maximum in its column
//
//Example 2:
//
//Input: matrix = [[1, 10, 4, 2],[9,3,8,7],[15,16,17,12]]
//Output:[12]
//Explanation: 12 is the only lucky number since it is the minimum in its row and the maximum in its column.
//
//Example 3:
//
//Input: matrix = [[7, 8],[1,2]]
//Output:[7]
//
// 
//
//Constraints:
//
//m == mat.length
//    n == mat[i].length
//    1 <= n, m <= 50
//    1 <= matrix[i][j] <= 10 ^ 5.
//    All elements in the matrix are distinct.
//
//

