using System;
namespace Training
{
    public class Element<T>
    {
        public Element<T> Next;

        public T Val;

        public Element(T val)
        {
            this.Next = null;
            this.Val = val;
        }

    }
}
