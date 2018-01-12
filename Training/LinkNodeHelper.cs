using System;
namespace Training
{
    public class LinkNodeHelper<T>
    {
        public LinkNodeHelper()
        {
        }

        public static LinkNode<T> reverseLinkNode(LinkNode<T> head)
        {

            if(head == null || head.Next == null)
            {
                return head;
                
            }

            //three pointers 

            LinkNode<T> ptrA, ptrB, ptrTmp;
            ptrA = head;
            ptrB = ptrA.Next;

            head.Next = null;

            while(ptrA !=null  && ptrB !=null)
            {
                ptrTmp = ptrB.Next;
                ptrB.Next = ptrA;
                ptrA = ptrB;
                ptrB = ptrTmp;

            }
            return ptrA;
        }


        public static LinkNode<T> reverseLinkNodeAtPlace(LinkNode<T> head , int b , int e)
        {
            if (head == null || head.Next == null)
            {
                return head;

            }

            //three pointers 

            LinkNode<T> ptrA, ptrB, ptrTmp, ptrOld;

            ptrOld = head;
            ptrOld.Next = ptrOld.Next;
            ptrA = head;
            ptrB = ptrA.Next;
       
            int index = 1;
            while (ptrA != null && ptrB != null)
            {
                if (index  >= b && index  <= e)
                {
                    ptrTmp = ptrB.Next;
                    ptrB.Next = ptrA;
                    ptrA = ptrB;
                    ptrB = ptrTmp;
                }
                else{

                    ptrA = ptrB;
                    ptrB = ptrB.Next;
                }
                index += 1;

            }
            return ptrOld;

        }

        public static LinkNode<T> removeItem(LinkNode<T> head, T val)
        {
            LinkNode<T> ptrA = head;
            while(ptrA.Next !=null)
            {

                if (ptrA.Next.Val.Equals(val))
                {
                    ptrA.Next = ptrA.Next.Next;

                }
                else
                    ptrA= ptrA.Next;

            }
            return head.Val.Equals(val) ? head.Next : head;
        }


    }
}
