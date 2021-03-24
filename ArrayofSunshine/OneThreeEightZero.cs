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
            int row = 0;
           
            int count = 0;
            while (searching)
            {
                int min = matrix[row][0];


                //if its the smallest in its column move to step 2
                //if it is not, then move over to the next value in the row and repeat.
                //if none in that row satisfy, +1 the row. repeat step 1. You don't need to compare to the previous row these will be bigger logically
                for (int col = 0; col <= matrix[row].Length-1; col++)
                {

                   
                    if (matrix[row][col] < min)
                    //matrix[col is constant][row is iterator]
                    {
                        
                        //seeing if num is SMALLEST IN THE ROW
                        //to look thru row, you're changing the var COL

                        min = matrix[row][col];
                        count = col;
                    }
                     
                }
                //2. Found smallest. Is it the biggest in it's column? Iterate thru column with matrix[j(iterator will be col)][row will be constant]
                //if its the biggest in its row, add it to the list, otherwise +1 to row and start over again. 

                int minimum = min;
              
                int max = min;

                foreach(int[] element in matrix)
               
                  
                    //to iterate thru column to find biggest number CHANGE THE ROW VAL
                    if (element[count]>min)
                    {
                        //if you find a num in the column bigger than our current target(min)
                        //set it equal to test condition
                        //jump to the next ROW 

                        max = element[count];
                        row++;

                        //if row is not equal to the matrix's length, break out and repeat 
                        if (row != matrix.Length)
                        {
                            searching = true;
                          
                            break;
                        }
 
                    }

                
                //if the min val hasn't changed since the second loop/it is also the max in its column-add it to the list
                if (max == min)
                {
                    test.Add(min);
                    row++;
                }
                
                //regardless if the row # equals the length of the matrix, we're at the last row and we need to break out of our while condition
                if (row >= matrix.Length)
                {
                    searching = false;
                    return test;
                }
                min = 0;
                max = 0;
             
            }

            return test;  //if its the smallest in its row
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

