using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Training
{
    public class Algorithms
    {

        /*
         * 
         * 125. Valid Palindrome
         * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
            For example,
            "A man, a plan, a canal: Panama" is a palindrome.
            "race a car" is not a palindrome.
         */
        public static bool IsPalindrome(string s)
        {

            Regex rgx = new Regex(@"\W");
            s = rgx.Replace(s, "");
            char[] tmp  = s.ToCharArray();
            int i = 0;

            while ( i < s.Length)
            {

                if(char.ToLower( s[i])  !=  char.ToLower(s[s.Length-1-i]))
                {
                    return false;
                }
                i++;
            }
            return true;

        }

        //680. Valid Palindrome II
        /*
         * Given a non-empty string s, you may delete at most one character. Judge whether you can make it a palindrome.
         */
        public static bool IsPalindromeTwo(string s)
        {

       
          
            int i = 0;
         

            while (i < s.Length/2)
            {

                if( s[i] != s[s.Length -1-i])
                {
                    int end =s.Length - 1 - i;
                    return validateWords(s, i + 1, end) || validateWords(s, i, end - 1);
                }
                i++;
                
            }
            return true;

        }
        public static bool validateWords(string s , int begin ,int end)
        {

            for (int k = 0; k<= (end- begin)/2; k++)
            {
                if (s[begin + k] != s[end -k  ])
                    return false;

            }
            return true;
        }

        /*
         * 
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.


        */
        public static bool IsValid(string s)
        {

            Stack<char> st = new Stack<char>();

            if (s.Length == 0)
                return true;
            int index = 0;
     

            while( index < s.Length)
            {
                switch(s[index])
                {
                    case '(':
                        st.Push(')');
                        break;
                    case '{':
                        st.Push('}');
                        break;
                    case '[':
                        st.Push(']');
                        break;

                    case ')':
                    case '}':
                    case ']':
                        if (st.Size == 0 ||st.Pop() != s[index])
                            return false;
                        break;
                    
                }
                index++;
            }
            return st.Size ==0;

        }

        public static int Trap(int[] height)
        {

            if (height.Length < 3)
                return 0;

            int ptrA = 0;
            int ptrB =0;
            int count = 0;

            while(ptrA < height.Length)
            {


                if (ptrB <height.Length && height[ptrB] >= height[ptrA])
                {
                    count += SumTrap(height, ptrA, ptrB);
                    ptrA = ptrB;

                }
                else
                {
                    if (ptrB >= height.Length-1)
                    {
                        ptrA++;
                        ptrB = ptrA ;
                    }
                    
                }


                ptrB++;

                
            }
            return count;
        }

      

        public static int SumTrap(int[] nums , int ptrA , int ptrB)
        {
            int top = Math.Min(nums[ptrA], nums[ptrB]);
            if (top == 0) return 0;
            int sum = 0;

            int index = ptrA;

            while(index < ptrB)
            {
                sum += top - nums[index];
                index++;
            }
            return sum;
            
        }

        /*
         * 
         * 
         * 
         *   Maximum Size Subarray Sum Equals k
Given an array nums and a target value k, find the maximum length of a subarray that sums to k. If there isn't one, return 0 instead.

Note:
The sum of the entire nums array is guaranteed to fit within the 32-bit signed integer range.

Example 1:
Given nums = [1, -1, 5, -2, 3], k = 3,
return 4. (because the subarray [1, -1, 5, -2] sums to 3 and is the longest)

Example 2:
Given nums = [-2, -1, 2, 1], k = 1,
return 2. (because the subarray [-1, 2] sums to 1 and is the longest)

Follow Up:
Can you do it in O(n) time?
         * */
        public static int MaxSubArrayLen2(int[] nums, int k)
        {
            if (nums.Length == 0)
                return 0;
            int steps = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                int j = i;
                int newSteps = 0;
                int sum = 0;
                while (j < nums.Length)
                {
                    sum += nums[j];

                    j++;
                    newSteps++;




                    if (sum == k)
                    {
                        steps = Math.Max(steps, newSteps);

                    }


                }
            }
            return steps;


        }

        /*

  Add Binary
Given two binary strings, return their sum (also a binary string).

For example,
a = "11"
b = "1"
Return "100".
        */
        public static string AddBinary(string a, string b)
        {
            if (a == string.Empty && b == string.Empty)
                return "0";
            int carry = 0;
            string result = "";

            int index = 0;
            while ((index < a.Length && index < b.Length) || carry != 0)
            {

                int ax = 0;
                int bx = 0;
                int res = 0;
                if (index < a.Length)
                {
                    ax = int.Parse(a[a.Length - 1 - index].ToString());

                }
                if (index < b.Length)
                {
                    bx = int.Parse(b[b.Length - 1 - index].ToString());

                }
                res = ax + bx + carry;
                if (res > 1)
                {
                    res = res % 2;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                result = res.ToString() + result;
                index++;
            }

            return result;


        }
        /*
         * 
         * 
         * 
         *   Minimum Size Subarray Sum
Given an array of n positive integers and a positive integer s, find the minimal length of a contiguous subarray of which the sum ≥ s. If there isn't one, return 0 instead.

For example, given the array [2,3,1,2,4,3] and s = 7,
the subarray [4,3] has the minimal length under the problem constraint.

click to show more practice.

More practice:
If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log n).

Credits:
Special thanks to @Freezen for adding this problem and creating all test cases.
         * */

        public static int MinSubArrayLen(int s, int[] nums)
        {

            if (nums.Length == 0)
                return 0;
            int steps = 0;
            int auxSteps = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                if (nums[i] >= s)
                    return 1;
                auxSteps = 0;
                sum = 0;
                while (j < nums.Length)
                {
                    auxSteps++;
                    sum += nums[j];
                    if (sum >= s)
                    {
                        steps = (steps > 1) ? Math.Min(steps, auxSteps) : auxSteps;
                        break;
                    }
                    j++;
                }




            }
            return steps;


        }
      
        public Algorithms()
        {
        }
    }
}
