using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mange
{
    internal class sort
    {
        public void sorted(Listt<Book> list)
        {
            Book key;
            int j;
            if (list == null || list.Count <= 1)
            {
                return;
            }
               

            for (int i = 1; i < list.Count; i++)
            {
                key = list[i];
                j = i - 1;
                while (j >= 0 && list[j].BookId > key.BookId)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
        }
    }
}

