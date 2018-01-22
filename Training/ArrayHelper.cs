using System;
using System.Collections.Generic;
namespace Training
{
    public class ArrayHelper
    {

        /*
         * 189. Rotate Array
         * 
         * Rotate an array of n elements to the right by k steps.

For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].

Note:
Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.

[show hint]

Related problem: Reverse Words in a String II

Credits:
Special thanks to @Freezen for adding this problem and creating all test cases.


         * 
        */
        public static void Rotate(int[] nums, int k)
        {
            if (nums == null || k == 0)
                return;
            int[] aux = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                aux[(i + k) % nums.Length] = nums[i];

            }


            aux.CopyTo(nums,0);

           

        }

        /*Reverse Words in a String II
         * 
         * Given an input string, reverse the string word by word. A word is defined as a sequence of non-space characters.

The input string does not contain leading or trailing spaces and the words are always separated by a single space.

For example,
Given s = "the sky is blue",
return "blue is sky the".

Could you do it in-place without allocating extra space?

Related problem: Rotate Array

Update (2017-10-16):
We have updated the function signature to accept a character array, so please reset to the default code definition by clicking on the reload button above the code editor. Also, Run Code is now available!
         * */
        public static string ReverseWords(string str)
        {

            if (str.Length == 0)
                return str;

            if(str.TrimEnd().TrimStart().Length ==0)
            {
                return "";
            }
            str = Reverse(str, 0, str.Length);

            int begin = 0;
            for (int i = 0; i < str.Length + 1; i++)
            {
                if (i == str.Length || str[i] == ' ')
                {
                    str = Reverse(str, begin, i);
                    begin = i + 1;
                }


            }

            return str;

        }
        public static string Reverse (string str, int begin , int end)
        {

            char[] aux = str.ToCharArray();
            
            for (int i = 0; i < (end - begin) / 2; i++)
            {
                char tmp =aux[begin + i];
               aux[begin + i] = aux[end - 1 - i];
                aux[end-1-i] = tmp;

            }

            return new String( aux);
    
        }

        /*
        public static void ReverseWords(char[] str)
        {

            if (str.Length == 0)
                return;
            Reverse(str, 0, str.Length);

            int begin = 0;
            for (int i = 0; i < str.Length + 1; i++)
            {
                if (i == str.Length || str[i] == ' ')
                {
                    Reverse(str, begin, i);
                    begin = i + 1;
                }


            }

        }
        public static void Reverse(char[] str, int begin, int end)
        {

            for (int i = 0; i < (end - begin) / 2; i++)
            {
                char tmp = str[begin + i];
                str[begin + i] = str[end - 1 - i];
                str[end - 1 - i] = tmp;

            }

        }*/


        public class IndexHelper
        {
            public int from;
            public int to;
            public IndexHelper(int f, int t)
            {
                from = f;
                to = t;
            }
        }


       
        public ArrayHelper()
        {
        }
    }
}
