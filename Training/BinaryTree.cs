using System;
namespace Training
{

    public class TreeNode{
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int v)
        {
            val = v;
        }


    }
    public class BinaryTree
    {

        public TreeNode root;

        public int height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int lheight = height(root.left);
            int rheight = height(root.right);

            if(lheight > rheight)
            {

                return lheight + 1;
            }
            return rheight + 1;
            
        }

        public void PrintLevelOrder()
        {
            int h = height(root);
            for (int i = 1; i <= h; i++){

                printGivenLevel(root,i,i);
            }


        }

        public void printGivenLevel(TreeNode root , int level, int reference)
        {
            if(root == null)
            {
                return;
            }
            if (level == 1)
                Console.WriteLine(reference.ToString() +" "+ root.val);
            else if (level > 1){

                printGivenLevel(root.left , level-1,reference);
                printGivenLevel(root.right, level - 1,reference);
            }
            
        }

        public BinaryTree()
        {
            root = null;
        }
    }
}
