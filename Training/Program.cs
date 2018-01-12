using System;

namespace Training
{
    class MainClass
    {





        public static void Main(string[] args)
        {
            LinkNode<int> lnkNode = new LinkNode<int>(1);
            lnkNode.append(3);
            lnkNode.append(5);
            //lnkNode.print();
            //LinkNode<int> lnkNodeA = LinkNodeHelper<int>.reverseLinkNode(lnkNode);


            LinkNode<int> lnkNodeA = LinkNodeHelper<int>.removeItem(lnkNode,3); //[1,50]

            //*******************************************************************************
            //Remove Special
            LinkNode<int> lnkNodeEspecial = new LinkNode<int>(1);
            lnkNodeEspecial.append(2);
            lnkNodeEspecial.append(3);
            lnkNodeEspecial.append(4);
            lnkNodeEspecial.append(5);
            lnkNodeEspecial = LinkNodeHelper<int>.reverseLinkNodeAtPlace(lnkNodeEspecial, 2,4); //[1,4,3,2,5]
            lnkNodeEspecial.print();

        }
    }
}
