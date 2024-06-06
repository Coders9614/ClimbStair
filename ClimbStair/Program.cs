using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbStair
{
    internal class Solution
    {

        //This is the method signature for ClimbStairs.
        public int ClimbStairs(int n)
        {
            //If n is less than or equal to 1
            //(i.e., there are 0 or 1 steps), we return 1 (base case).
            if (n <= 1)
            {
                return 1;
            }
            //The array size is n + 1 to accommodate steps from 0 to n.
            int[] stair = new int[n + 1];
            //Initialize the value at index 0 to 1
            //there’s only one way to reach step 0: don’t take any steps.
            stair[0] = 1;
            //Initialize the value at index 1 to 1
            //there’s only one way to reach step 1: take one step.
            stair[1] = 1;

            //Start a loop from step 2
            //since we’ve already handled steps 0 and 1).
            //Continue until i reaches n.
            for (int i = 2; i <= n; i++)
            {
                //It’s the sum of ways to reach the previous two steps
                //dp[i - 1] and dp[i - 2].
                stair[i] = stair[i - 1] + stair[i - 2];
            }
            //Return the total number of ways to climb to the top
            //reached by taking n steps.
            return stair[n];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Example 1
            int n1 = 2;
            int result1 = solution.ClimbStairs(n1);
            Console.WriteLine($"Example 1:\nInput: n = {n1}\nOutput: {result1}\nExplanation: There are two ways to climb to the top.\n1. 1 step + 1 step\n2. 2 steps\n");

            // Example 2
            int n2 = 3;
            int result2 = solution.ClimbStairs(n2);
            Console.WriteLine($"Example 2:\nInput: n = {n2}\nOutput: {result2}\nExplanation: There are three ways to climb to the top.\n1. 1 step + 1 step + 1 step\n2. 1 step + 2 steps\n3. 2 steps + 1 step\n");
            Console.ReadKey();
        }
    }
}
