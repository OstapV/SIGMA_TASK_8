using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGMA_7_1
{
    delegate int CompareValues(object x1, object x2);
    class Bubble
    {
        static public void Sort(object[] arr, CompareValues compare)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (compare(arr[j], arr[j + 1]) > 0)
                    {
                        object temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

    }
}
