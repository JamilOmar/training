using System;
namespace Training
{
     //First in First Out
    //A
    //B
    // A B C

    // OUT A
   
    public class Queue<T>
    {
        public int Max;
        public int Size;
        public Element<T> Head; 
        public Element<T> Tail; 
        public void Enqueue()
        {
            
        }

        public void Enqueue(T val)
        {
            if( this.Size < this.Max)
            {
                Element<T> newElement = new Element<T>(val);
                if (this.Head == null)
                {
                    this.Head = newElement;
                    this.Tail = this.Head;

                }
                else
                {
                    this.Tail.Next = newElement;
                    this.Tail = this.Tail.Next;
                   
                    
                }
                this.Size++;

            }
            else
                throw new Exception("MAX STACK");
        }


        public T Dequeue()
        {
            if (Size != 0)
            {

                T val = Head.Val;
                Head = Head.Next;
                Size--;
                return val;
            }
            else
                throw new Exception("NO ITEMS");


        }

        public T Peek()
        {
            if (Size != 0)
            {

                return Head.Val;
            }
            else
                throw new Exception("NO ITEMS");

        }


        public Queue()
        {
        }
    }
}
