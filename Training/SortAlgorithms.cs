using System;
using System.Collections.Generic;
namespace Training
{
    public class SortAlgorithms
    {


        static void Merge(int[] arr, int l , int m , int r)
        {

            List<string> s = new List<string>();

            int n1 = m - l + 1;
            int n2 = r - m;

            int[] left = new int[n1];
            int[] right = new int[n2];
            for (int i = 0; i < n1; i++)
                left[i] = arr[i];

            for (int i = 0; i < n2; i++)
                right[i] = arr[i+1+m];


            int iLeft = 0;
            int iRight = 0;

            int k = l;

            while(iLeft < n1 && iRight < n2)
            {

                if(left[iLeft] <= right[iRight])
                {
                    arr[k] = left[iLeft];
                    iLeft++;
                }
                else{

                    arr[k] = right[iRight];
                    iRight++;
                }
                k++;
            }

            while( iLeft < n1)
            {
                arr[k] = left[iLeft];
                iLeft++;
                k++;

            }

            while (iRight < n2)
            {
                arr[k] = right[iRight];
                iRight++;
                k++;

            }
        }

        public static void Sort(int [] arr, int l, int r)
        {
            if(l<r)
            {
                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m+1,r);
                Merge(arr, l ,m ,r);

                
            }
            
        }
        public SortAlgorithms()
        {
        }
    }
}
