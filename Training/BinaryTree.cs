using System;
using System.Collections.Generic;
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


        public void BFSQueue()
        {


            if (this.root == null)
                return;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Max = 15;

            q.Enqueue(this.root);

            while(q.Size > 0)
            {
                TreeNode n = q.Dequeue();
                Console.WriteLine(n.val.ToString());

                if (n.left != null)
                    q.Enqueue(n.left);

                if (n.right != null)
                    q.Enqueue(n.right);
            }



        }



        public string Serialize()
        {

            List<string> result = new List<string>();


            if (this.root == null)
                return "";

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Max = 15;

            q.Enqueue(this.root);

            while (q.Size > 0)
            {
                TreeNode n = q.Dequeue();

                if(n != null)
                {
                    result.Add(n.val.ToString());
                    q.Enqueue(n.left);
                    q.Enqueue(n.right);
                }
                else
                {
                    result.Add("@@");
                }


               
            }

            return String.Join(",", result.ToArray());

        }

        public TreeNode Deserialize(string ser)
        {
            string[] results = ser.Split(',');
            int i = 1;
            if (results.Length == 0)
                return null;
            TreeNode root = new TreeNode(Int32.Parse(results[i]));

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Max = 15;
            q.Enqueue(root);
            while(q.Size >0)
            {

                TreeNode tmp = q.Dequeue();

                if (tmp == null)
                    continue;
                if(results[i] != "@@")
                {
                    tmp.left = new TreeNode(Int32.Parse(results[i]));
                    q.Enqueue(tmp.left);
                }
                else
                {
                    tmp.left = null;
                    q.Enqueue(null);
                }

                i++;
                if (results[i] != "@@")
                {
                    tmp.right = new TreeNode(Int32.Parse(results[i]));
                    q.Enqueue(tmp.right);
                }
                else
                {
                    tmp.right = null;
                    q.Enqueue(null);
                }
                i++;
            }

            return root;

            
        }


        public void FromTreeToLinkedList()
        {
            if (this.root == null)
                return;

            System.Collections.Generic.Stack<TreeNode> stack = new System.Collections.Generic.Stack<TreeNode>();
            TreeNode ptr = root;
        

            while(ptr!=null || stack.Count >0)
            {


                if (ptr.right != null)
                    stack.Push(ptr.right);

                if (ptr.left != null)
                {
                    ptr.right = ptr.left;
                    ptr.left = null;
                }else if(stack.Count> 0)
                {
                    TreeNode tmp = stack.Pop();
                    ptr.right = tmp;
                }


                ptr = ptr.right;
            }


        }


        public BinaryTree()
        {
            root = null;
        }
    }
}
