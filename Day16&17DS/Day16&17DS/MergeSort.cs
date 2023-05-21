using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17DS
{
    public class MergeSort
    {
        public static string[] mergeSort(string[] Arr, int lo, int hi)
        {
            if (lo == hi)
            {
                string[] A = { Arr[lo] };
                return A;
            }
            int mid = lo + (hi - lo) / 2;
            string[] arr1 = mergeSort(Arr, lo, mid);
            string[] arr2 = mergeSort(Arr, mid + 1, hi);

            string[] arr3 = merge(arr1, arr2);
            return arr3;
        }

        public static string[] merge(string[] Arr1, string[] Arr2)
        {
            int m = Arr1.Length;
            int n = Arr2.Length;
            string[] Arr3 = new string[m + n];

            int idx = 0;

            int i = 0;
            int j = 0;

            while (i < m && j < n)
            {
                if (isAlphabeticallySmaller(Arr1[i], Arr2[j]))
                {

                    Arr3[idx] = Arr1[i];
                    i++;
                    idx++;
                }
                else
                {
                    Arr3[idx] = Arr2[j];
                    j++;
                    idx++;
                }
            }
            while (i < m)
            {
                Arr3[idx] = Arr1[i];
                i++;
                idx++;
            }
            while (j < n)
            {
                Arr3[idx] = Arr2[j];
                j++;
                idx++;
            }
            return Arr3;
        }

        // Return true if str1 appears before
        // str2 in alphabetical order
        public static bool isAlphabeticallySmaller(string str1,
                                            string str2)
        {
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
            if (string.Compare(str1, str2) < 0)
            {
                return true;
            }
            return false;
        }

       
    }
}
