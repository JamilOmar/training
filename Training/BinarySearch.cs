using System;
namespace Training
{
    public class BinarySearch
    {
        public int BinarySearchLinear(int[] arr, int x)
        {

            int l = 0; int r = arr.Length - 1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;

                if(arr[mid] == x)
                {
                    return mid;
                }
                if(arr[mid]<x)
                {
                    l = mid + 1;
                }else{

                    r = mid - 1;
                }

            }

            return -1;
        }

        public int BinarySeach(int[] arr, int l, int r, int x)
        {


            if(r>=l)
            {

                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;
                if(arr[mid] > x)
                {
                   return BinarySeach(arr,l,mid-1,x);
                }
               return BinarySeach(arr, mid + 1, r, x);
            }
            return -1;

        }
        public BinarySearch()
        {
        }
    }
}
