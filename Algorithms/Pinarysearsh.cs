using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mange
{
    internal static class BinarySearch
    {
        public static int searsh(Listt<Book> list, int Id)
        {
            if (list == null || list.Count == 0)
            { 
                return -1;
            }
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                int mid=(left+right)/2;
                if (list[mid].BookId == Id)
                {
                    return mid;
                }else if (list[mid].BookId < Id)
                {
                    left = mid+1;
                }
                else
                {
                    right =mid-1;
                }
            }
            return -1;
        }
    }
}
