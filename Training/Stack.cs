using System;
namespace Training
{
    public class Stack<T>
    {

        public Element<T> Top;
        public int Max;
        public int Size;


        public T Pop()
        {
            if (Size ==0)
            {
                T val = Top.Val;
                Top = Top.Next;
                Size--;
                return val;
            }
            else
                throw new Exception("NO ITEMS");

            
        }
        public void Push(T val)
        {

            if (Size < Max)
            {
                Element<T> newElement = new Element<T>(val);


                if (Top != null)
                {
                    newElement.Next = Top;
                    Top = newElement;

                }
                else
                {
                    Top = newElement;
                }
                Size++;
            }
            else
                throw new Exception("MAX STACK");


        }

        public T Peek()
        {
            if (Size != 0)
            {
               
                return Top.Val;
            }
            else
                throw new Exception("NO ITEMS");
            
        }
        public Stack()
        {
            this.Max = 0;
            this.Size = 0;
            this.Top = null;
        }
    }
}
