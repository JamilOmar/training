using System;
using System.Collections.Generic;
namespace Training
{
    public class LinkNode<T>
    {
        T val;
        LinkNode<T> next;

        public LinkNode<T> Next { get => next; set => next = value; }
        public T Val { get => val; set => val = value; }

        public LinkNode(T v)
        {
            this.val = v;
            next = null;
        }

        public LinkNode()
        {
           
            next = null;
        }

     

        public void append(T v)
        {
            LinkNode<T> ptr = this;
            while(ptr.next!= null)
            {

                ptr = ptr.next;
            }
            ptr.next = new LinkNode<T>(v);
            
        }

        public void print()
        {
            LinkNode<T> ptr = this;

            while(ptr !=null)
            {
                Console.Write(ptr.val.ToString());
                ptr = ptr.next;
            }
            
        }
    }
}
