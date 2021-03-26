using System;

namespace AversiontoRecursion
{
    class Program
    {
        static void Main(string[] args)
        {

            FibonacciRecursive(5);
        }



        public static int Factorial(int x)
        {
            int y = x - 1;
            int sum = x;
            if (y != 1)
            {
                sum *= Factorial(x - 1);
            }
            return sum;
        }

        public static int FindFactorR(int x)
        {
            //base case
            if (x == 2)
            {
                return 2;
            }

            return x * FindFactorR(x - 1);
        }

        public static int FactorialIterative(int x)
        {
            int sum = 0;
            int y = x - 1;
            sum = x;
            do
            {
                sum *= y;
                y--;
            } while (y != 1);

            return sum;
        }

        public static int FibonacciIteration(int val)
        {
            //given a val as an index, find where in the fib sequence it would be and return that num
            int x = 0;
            int y = 0;
            int[] fib = new int[val + 1];
            int sum = 0;
            if (val < 2)
            {
                return val;
            }

            x = 0;
            y = 1;
            for (int i = 0; i < fib.Length; i++)
            {
                fib[i] = x + y;
                if (val == i)
                {
                    return fib[i];
                }
                else
                {
                    x = y;
                    y = fib[i];

                }
                sum = fib[i];
            }
            return sum;
        }

        public static int FibonacciRecursive(int val)
        {
            //break statement
            if (val <= 1)
            {

                return val;
            }
            return FibonacciRecursive(val - 1);
        }



    }

}




