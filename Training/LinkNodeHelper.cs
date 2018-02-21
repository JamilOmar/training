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

                        if (head == null || head.Next == null)
                        {
                            return head;

                        }

                        //three pointers 

                        LinkNode<T> ptrA, ptrB, ptrTmp;
                        ptrA = head;
                        ptrB = ptrA.Next;

                        head.Next = null;

                        while (ptrA != null && ptrB != null)
                        {
                            ptrTmp = ptrB.Next;
                            ptrB.Next = ptrA;
                            ptrA = ptrB;
                            ptrB = ptrTmp;

                        }
                        return ptrA;
                    }
                    public static LinkNode<T>[] SplitListToParts(LinkNode<T> root, int k)
                    {
                        if (root == null)

                            return null;
                        LinkNode<T> ptr = root;
                        int count = 0;

                        //e.g. 10 / 3 = dv =3
                        // 10 % 3 = dm -> dm + dv // only at first 
                        int dv = 0;
                        int dm = 0;

                        //1 iteraction get length 
                        while (ptr != null)
                        {
                            count++;
                            ptr = ptr.Next;
                        }

                      
                            dv = count / k;
                            dm = count % k;


                        LinkNode<T>[] result = new LinkNode<T>[k];
                        ptr = root;

                        for (int i = 0; i < k; i++)
                        {

                            LinkNode<T> newNode = new LinkNode<T>();
                            LinkNode<T> tmp = newNode;


                            for (int j = 0; j < dv + (i < dm ? 1 : 0); j++)
                            {
                                tmp = tmp.Next = new LinkNode<T>(ptr.Val);
                                if(ptr !=null)
                                    ptr = ptr.Next;
                            }
                          
                            result[i] = newNode.Next;

                        }
                        return result;

                    }
                   



                    /*
                     * with capacity O(1)
                     * with Execution O(n)
                     * case [a,d,a ] true
                     * case [a,m,m,a] true
                     * case  [ d,e,s,t,s,e,d] true
                     * when lenght is even or odd 
                     * 
                     * split in two
                     * reverse two
                     * compare for each element of list one
                     * 
                     * */
                    public static bool IsPalindrome(LinkNode<T> head)
                    {
                        if (head == null)
                            return false;

                        LinkNode<T> ptrFast = head;
                        LinkNode<T> ptrSlow = head;
                        LinkNode<T> prevMiddle = head;
                        LinkNode<T> middle = null;
                        //tortoise and hare method 
                        while (ptrFast != null && ptrFast.Next != null)
                        {
                            ptrFast = ptrFast.Next.Next;
                            prevMiddle = ptrSlow;
                            ptrSlow = ptrSlow.Next;

                        }

                        if (ptrFast != null)//odd
                        {
                            middle = ptrSlow;
                            ptrSlow = ptrSlow.Next;

                        }
                        LinkNode<T> ptrSecondHalf = ptrSlow;

                        prevMiddle.Next = null;

                        LinkNode<T> ptrReverse = reverseLinkNode(ptrSecondHalf);
                        bool res = CompareList(head, ptrSecondHalf);
                        ptrReverse = reverseLinkNode(ptrReverse);

                        if (middle != null)
                        {
                            middle.Next = ptrReverse;
                            prevMiddle.Next = middle;
                        }
                        else
                        {
                            prevMiddle.Next = ptrReverse;

                        }

                        return res;

                    }

                    public static bool CompareList(LinkNode<T> l1, LinkNode<T> l2)
                    {

                        LinkNode<T> ptrL1 = l1;

                        LinkNode<T> ptrL2 = l2;
                        while (ptrL1 != null)
                        {
                            if (!ptrL1.Val.Equals(ptrL2.Val))
                                return false;
                            ptrL1 = ptrL1.Next;
                            ptrL2 = ptrL2.Next;

                        }
                        if (ptrL1 == null && ptrL2 == null)
                            return true;
                        return false;

                    }

                    /*
                     * 
                     * 
                     * case [1,2,3,4,5] m = 2 , n =4 
                     * 
                     * [1,4,3,2,5]
                     * 
                     * 
                     * 1 - if head is null return null
                     *  create a pointer  from start  1
                     * ptr =1 
                     * create an index = 1;
                     * 
                     * Increment the value of index and ptr while ptr != null
                     * 
                     * 2 - if index = m- 1
                     * store a pointer  for the value for attach the reverse list
                     * ptrPrv = ptr;
                     * 
                     * 3 - if index = m 
                     * create a pointer to that value for reverse the list
                     * ptrM = ptr;
                     * 
                     * 4 - if index = n
                     * 
                     * create a pointer to the next value for reattached to the list
                     * prtN = ptr.Next
                     * ptr.Next =null // for terminate the iteration
                     * 
                     * if ptrM == null // no list
                     * 
                     * return head;
                     * 
                     * reverse ptrM
                     *[IMPORTAN] for unified the lists
                     * ptrM.next = ptrN;
                     * if ptrPrev !=null 
                     * ptrPrev.next == ptrA (New Pointer for reverse)
                     * else 
                     * return ptrA
                     * 
                     * return head;
                     * 
                     * */
                    public static LinkNode<T> reverseLinkNodeAtPlace(LinkNode<T> head, int m, int n)
                    {

                        if (head == null)
                            return head;
                        int index = 1;
                        LinkNode<T> ptr = head;
                        LinkNode<T> ptrPrev = null;
                        LinkNode<T> ptrM = null;
                        LinkNode<T> ptrN = null;
                        while (ptr != null)
                        {
                            if (index == m - 1)
                            {
                                ptrPrev = ptr;

                            }
                            if (index == m)
                            {

                                ptrM = ptr;
                            }
                            if (index == n)
                            {

                                ptrN = ptr.Next;
                                ptr.Next = null;

                            }

                            ptr = ptr.Next;
                            index += 1;
                        }
                        //perform reverse
                        if (ptrM == null)
                            return head;
                        LinkNode<T> ptrA = ptrM;
                        LinkNode<T> ptrB = ptrA.Next;
                        LinkNode<T> ptrTmp = null;
                        ptrA.Next = ptrN;

                        while (ptrA != null && ptrB != null)
                        {
                            ptrTmp = ptrB.Next;
                            ptrB.Next = ptrA;
                            ptrA = ptrB;
                            ptrB = ptrTmp;

                        }

                        if (ptrPrev != null)
                            ptrPrev.Next = ptrA;
                        else
                            return ptrA;
                        return head;


                    }





                    public static LinkNode<T> RotateRight(LinkNode<T> head, int k)
                    {

                        if (head == null)
                            return null;
                        if (k == 0)
                            return head;

                        LinkNode<T> ptr = head;
                        int len = 0;
                        while(ptr!=null)
                        {
                            ptr = ptr.Next;
                            len++;
                        }
                        ptr = head;

                        LinkNode<T> ptrNew = null;
                        int rotator = 1;
                        while(ptr!=null)
                        {
                            // if k > len
                            int aux = k > len ? len - k % len : len - k;
                            if (rotator == aux)
                            {
                                ptrNew = ptr.Next;
                                ptr.Next = null;
                                
                            }
                            rotator++;
                            ptr = ptr.Next;
                        }

                        LinkNode<T> ptrNewAux = ptrNew;

                        while(ptrNewAux.Next != null)
                        {
                            ptrNewAux = ptrNewAux.Next;
                        }
                        ptrNewAux.Next = head;

                        return ptrNew;
                    }
                 
                    public static LinkNode<T> removeItem(LinkNode<T> head, T val)
                    {
                        LinkNode<T> ptrA = head;
                        while (ptrA.Next != null)
                        {

                            if (ptrA.Next.Val.Equals(val))
                            {
                                ptrA.Next = ptrA.Next.Next;

                            }
                            else
                                ptrA = ptrA.Next;

                        }
                        return head.Val.Equals(val) ? head.Next : head;
                    }



                    /*143. Reorder List
                     * 


            Given a singly linked list L: L0→L1→…→Ln-1→Ln,
            reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…

            You must do this in-place without altering the nodes' values.

            For example,
            Given {1,2,3,4}, reorder it to {1,4,2,3}.

                    */


                    public  static void insertInBetween(LinkNode<T> head, LinkNode<T> newNode)
                    {

                        LinkNode<T> ptr = head;
                        if (ptr.Next != null)
                        {

                            newNode.Next = ptr.Next;
                            ptr.Next = newNode;
                        }
                        else
                            ptr.Next = newNode;

                    }

                    public static LinkNode<T> removeTail(LinkNode<T> head)
                    {
                        LinkNode<T> ptr = head;

                        LinkNode<T> prev = null;

                        while (ptr.Next != null)
                        {
                            prev = ptr;
                            ptr = ptr.Next;
                        }
                        LinkNode<T> found = ptr;
                        ptr = null;
                        prev.Next = null;
                        return found;
                    }
                    public static void ReorderList(LinkNode<T> head)
                    {


                        LinkNode<T> ptrA = head;
                      

                        while (ptrA != null && ptrA.Next != null)
                        {
                            
                            LinkNode<T> last = removeTail(ptrA);
                            insertInBetween(ptrA, last);
                            ptrA = ptrA.Next; 
                            ptrA = ptrA.Next;

                        }


                    }
                    /*
                     * 
                     * 
                     * 19. Remove Nth Node From End of List
                     * Given a linked list, remove the nth node from the end of list and return its head.

            For example,

               Given linked list: 1->2->3->4->5, and n = 2.

               After removing the second node from the end, the linked list becomes 1->2->3->5.
            Note:
            Given n will always be valid.
            Try to do this in one pass.
                     * 
                     * */

                    public int getLength(LinkNode<T> head)
                    {
                        LinkNode<T> ptr = head;
                        int counter = 0;
                        while (ptr != null)
                        {
                            ptr = ptr.Next;
                            counter++;
                        }

                        return counter;

                    }

                    /*
                    public LinkNode<T> Merge(LinkNode<T> a ,LinkNode<T> b)
                    {

                        LinkNode<T> ptrA = a;

                        LinkNode<T> ptrB = b;

                        LinkNode<T> c  = new LinkNode<T>();

                        LinkNode<T> ptrC = c;


                        while(ptrA!=null && ptrB!=null)
                        {
                            if(ptrA.Val <=ptrB.Val)
                            {
                                ptrC.append(ptrA.Val);
                                ptrA = ptrA.Next;
                                ptrC = ptrC.Next;

                              
                            }
                            else
                            {
                                ptrC.append(ptrB.Val);
                                ptrB = ptrB.Next;
                                ptrC = ptrC.Next;
                            }

                        }

                        while (ptrA != null )
                        {
                          
                                ptrC.append(ptrA.Val);
                                ptrA = ptrA.Next;
                                ptrC = ptrC.Next;

                        }
                        while (ptrB != null)
                        {
                           
                                ptrC.append(ptrB.Val);
                                ptrB = ptrB.Next;
                                ptrC = ptrC.Next;


                        }
                        return c;



                    }
            */
                    public LinkNode<T> RemoveNthFromEnd(LinkNode<T> head, int n)
                    {



                        if (head == null)
                            return head;
                        if (n == 0)
                            return head;

                        LinkNode<T> ptr = head;
                        LinkNode<T> prev = null;
                        int length = getLength(ptr);


                        int pos = length - n;

                        if (pos < 0)
                        {

                            return null;
                        }
                        int index = 0;
                        while (ptr != null)
                        {
                            if (index == pos)
                            {
                                if (prev == null)
                                {
                                    return head.Next;
                                }
                                else
                                    prev.Next = ptr.Next;


                            }
                            else
                            {
                                prev = ptr;
                                ptr = ptr.Next;
                            }
                            index++;

                        }
                        return head;


                    }


                        public static LinkNode<T> ReverseKGroup(LinkNode<T> head, int k)
                        {
                            LinkNode<T> ptr = head;
                            LinkNode<T> m = ptr;
                            LinkNode<T> prev = null;
                            LinkNode<T> prevNext = null;
                            LinkNode<T> ptrN = null;
                            int i = 1;
                            int j = 1;
                            while (ptr != null)
                            {
                                if (i % k == 0){
                                  
                                    ptrN = ptr.Next;
                                    ptr.Next = null;
                                    LinkNode<T> tmp = Reverse(m, ptrN);
                                    if (prev != null)
                                    {
                                        j =1;
                                        prevNext = prev;
                                       while (j < i-k && prevNext.Next !=null)
                                        {
                                            prevNext = prevNext.Next;
                                            j++;
                                        }
                                        prevNext.Next = tmp;
                                    }
                                    else
                                    {
                                        prev = tmp;
                                   
                                    }
                                    ptr = ptrN;
                                    m = ptr;
                                }
                                else{
                              
                                ptr = ptr.Next;
                                }
                               i++;
                            }
                            return prev;
                        }


                    public static LinkNode<T> Reverse(LinkNode<T> head, LinkNode<T> next)
                    {

                        LinkNode<T> ptrA = head;
                        LinkNode<T> ptrB = ptrA.Next;
                        head.Next = next;
                        while (ptrA != null && ptrB != null)
                        {
                            LinkNode<T> ptrTmp = ptrB.Next;
                            ptrB.Next = ptrA;
                            ptrA = ptrB;
                            ptrB = ptrTmp;
                        }
                        return ptrA;
                    }


        public static LinkNode<T>  ReverseAsync(LinkNode<T> root)
                {

            LinkNode<T> ptrA = root;
            LinkNode<T> ptrB = ptrA.Next;



            if (ptrB == null)
                return ptrA;
            ptrB =  ReverseAsync(ptrB);
            LinkNode<T> q = ptrB;
            q.Next = ptrA;
            ptrA.Next = null;
            return ptrB;

                  
                }


                }
       


            }
