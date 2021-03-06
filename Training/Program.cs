﻿using System;

namespace Training
{
    class MainClass
    {
        static void Test_RemoveItem()
        {
            LinkNode<int> lnkNode = new LinkNode<int>(1);
            lnkNode.append(3);
            lnkNode.append(5);
            LinkNode<int> lnkNodeA = LinkNodeHelper<int>.removeItem(lnkNode, 3); //[1,50]
            lnkNodeA.print();


        }
        static void Test_RemoveItemSpecial()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
            lnkNodeEspecial = LinkNodeHelper<int>.reverseLinkNodeAtPlace(lnkNodeEspecial, 2, 4);
            Console.Write("It should be [1,4,3,2,5]");
            Console.WriteLine();
            lnkNodeEspecial.print();//[1,4,3,2,5]

        }


        static void Test_Palindrome()
        {
            LinkNode<string> lnkNodeEspecial = new LinkNode<string>("A");
            lnkNodeEspecial.append("D");
            lnkNodeEspecial.append("T");
            lnkNodeEspecial.append("D");
            lnkNodeEspecial.append("A");
            bool res = LinkNodeHelper<string>.IsPalindrome(lnkNodeEspecial);
            Console.Write("It should be true]:  "+ res.ToString());
            Console.WriteLine();
            lnkNodeEspecial.print();//[A,D,T,D,A]

        }
        static void Test_Palindrome2()
        {
            LinkNode<string> lnkNodeEspecial = new LinkNode<string>("A");
            lnkNodeEspecial.append("D");
            lnkNodeEspecial.append("D");
            lnkNodeEspecial.append("A");
            bool res = LinkNodeHelper<string>.IsPalindrome(lnkNodeEspecial);
            Console.Write("It should be true]:  " + res.ToString());
            Console.WriteLine();
            lnkNodeEspecial.print();//[A,D,D,A]

        }


        static void Test_SplitLinkedListParts()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
            lnkNodeEspecial.append(6);
            lnkNodeEspecial.append(7);
            lnkNodeEspecial.append(8);
            lnkNodeEspecial.append(9);
            lnkNodeEspecial.append(10);
            var data = LinkNodeHelper<int>.SplitListToParts(lnkNodeEspecial,3);

            Console.WriteLine(data);
          

        }

        static void Test_SplitLinkedListParts2()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            var data = LinkNodeHelper<int>.SplitListToParts(lnkNodeEspecial, 5);

            Console.WriteLine(data);


        }
        static void Test_SplitLinkedListParts3()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
            lnkNodeEspecial.append(6);
            lnkNodeEspecial.append(7);
            var data = LinkNodeHelper<int>.SplitListToParts(lnkNodeEspecial, 3);

            Console.WriteLine(data);


        }


        static void Test_RotateValues()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
           
            var data = LinkNodeHelper<int>.RotateRight(lnkNodeEspecial, 2);

            Console.WriteLine(data);
            Console.WriteLine();


        }



        static void Test_RotateValuesArray()
        {

            int[] data = new[] { 1, 2, 3, 4, 5, 6 };

            ArrayHelper.Rotate(data,3);
           
            Console.WriteLine(data);
            Console.WriteLine();


        }

        static void Test_RotateValuesArray2()
        {

            int[] data = new[] { 1, 2 };

            ArrayHelper.Rotate(data, 1);

            Console.WriteLine(data);
            Console.WriteLine();


        }


        static void Test_RotateValuesArray3()
        {

            int[] data = new[] { 1, 2 };

            ArrayHelper.Rotate(data, 0);

            Console.WriteLine(data);
            Console.WriteLine();


        }


        static void Test_RotateValuesArray4()
        {

            int[] data = new[] { 1, 2,3 };

            ArrayHelper.Rotate(data, 20000);

            Console.WriteLine(data);
            Console.WriteLine();


        }



        static void Test_RotateWords()
        {

           string data = "the sky is blue";

           data =  ArrayHelper.ReverseWords(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }


     

        static void Test_IsPalindromeAlgorithm()
        {

            string data = "A an, a plan, a canal: Panama";

            var result = Algorithms.IsPalindrome(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
      
        static void Test_IsPalindromeAlgorithmTwo()
        {

            string data = "abcna";

            var result = Algorithms.IsPalindromeTwo(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
        static void Test_IsPalindromeAlgorithmTwo2()
        {

            string data = "aba";

            var result = Algorithms.IsPalindromeTwo(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
        static void Test_IsPalindromeAlgorithmTwo3()
        {

            string data = "abc";

            var result = Algorithms.IsPalindromeTwo(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }



        static void Test_IsValidString()
        {

            string data = "(jamil)[omar]{falconi}";

            var result = Algorithms.IsValid(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
        static void Test_IsValidString2()
        {


            string data = "(jamil)[omar]{falconi}}";

            var result = Algorithms.IsValid(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
        static void Test_IsValidString3()
        {


            string data = "(jamil)[(omar)]{falconi}";

            var result = Algorithms.IsValid(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }



        static void Test_Trap()
        {

            int[] data = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

                var result = Algorithms.Trap(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
        static void Test_Trap2()
        {



            int[] data = new int[] { 3, 2, 1, 2, 3};

            var result = Algorithms.Trap(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }
        static void Test_Trap3()
        {



            int[] data = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            var result = Algorithms.Trap(data);

            Console.WriteLine(data);
            Console.WriteLine();


        }


        static void Test_ReorderList()
        {



            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
         
          
          
            LinkNodeHelper<int>.ReorderList(lnkNodeEspecial);

            Console.WriteLine(lnkNodeEspecial);
            Console.WriteLine();


        }
      


        static void Test_MaxSubArrayLen2_1()
        {



           
           var res =  Algorithms.MaxSubArrayLen2(new int[] { -2, 0, 1, -1 } , 1);
            Console.WriteLine(res);

        }

        static void Test_GroupAnagrams()
        {




            var res = Algorithms.GroupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat" });
            Console.WriteLine(res);

        }


        static void Test_Multiply()
        {




            var res = Algorithms.Multiply("40","22");
            Console.WriteLine(res);

        }


        static void Test_PrintLevelOrder()
        {

            BinaryTree tr = new BinaryTree();
            tr.root = new TreeNode(1);
            tr.root.left = new TreeNode(2);
            tr.root.right = new TreeNode(3);
            tr.root.left.left = new TreeNode(4);
            tr.root.left.right = new TreeNode(5);


            tr.PrintLevelOrder();


        }

        static void Test_PrintBFS()
        {

            BinaryTree tr = new BinaryTree();
            tr.root = new TreeNode(1);
            tr.root.left = new TreeNode(2);
            tr.root.right = new TreeNode(3);
            tr.root.left.left = new TreeNode(4);
            tr.root.left.right = new TreeNode(5);


            tr.BFSQueue();


        }

        static void Test_PrintSerialize()
        {

            BinaryTree tr = new BinaryTree();
            tr.root = new TreeNode(1);
            tr.root.left = new TreeNode(2);
            tr.root.right = new TreeNode(3);
            tr.root.left.left = new TreeNode(4);
            tr.root.left.right = new TreeNode(5);


            var result =  tr.Serialize();


        }


        static void Test_PrintLinkedList()
        {

            BinaryTree tr = new BinaryTree();
            tr.root = new TreeNode(1);
            tr.root.left = new TreeNode(2);
            tr.root.right = new TreeNode(3);
            tr.root.left.left = new TreeNode(4);
            tr.root.left.right = new TreeNode(5);
            tr.FromTreeToLinkedList();


        }



        static void Test_WildcardMatching()
        {



            var res = Algorithms.isMatch("pp", "pp");
            var res1 = Algorithms.isMatch("pp", "p?");

            var res2 = Algorithms.isMatch("pp", "*?");

            var res3 = Algorithms.isMatch("pp", "*");

            var res4 = Algorithms.isMatch("pp", "kl");
        }




        static void Test_MinSubstring()
        {

            var res= Algorithms.MinWindow("ADOBECODEBANC","ABC");
            Console.WriteLine(res);

        }
      
        static void Test_ReverseKGroup()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
            lnkNodeEspecial.append(6);
            lnkNodeEspecial = LinkNodeHelper<int>.ReverseKGroup(lnkNodeEspecial, 2);
       
            lnkNodeEspecial.print();//[1,4,3,2,5]

        }

        static void Test_ReverseAsync()
        {
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
            lnkNodeEspecial = LinkNodeHelper<int>.ReverseAsync(lnkNodeEspecial);

            lnkNodeEspecial.print();//[1,4,3,2,5]

        }

        static void Test_ExcelTile()
        {

            var res= Algorithms.ExcelTile(67);
            Console.WriteLine(res);

        }
      
       
        public static void Main(string[] args)
        {
            Test_ReverseAsync();
           
           

        }
    }
}
