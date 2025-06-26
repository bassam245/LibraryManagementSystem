using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mange
{
    internal class Listt<T>
    {
        T[] Items;
        int Capacty;
        private int count
        {
            get; set;
        }


        public Listt(int IntialCapacty = 4)
        {
            Capacty = IntialCapacty;
            Items = new T[Capacty];
            count = 0;

        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public T this[int index]
        {
            get { return Items[index]; }
            set { Items[index] = value; }
        }
        public void Expend()
        {
            Capacty *= 2;
            T[] Newitems = new T[Capacty];
            for (int i = 0; i < count; i++)
            {
                Newitems[i] = Items[i];
            }
            Items = Newitems;
        }
        public void Add(T item)
        {
            if (count == Capacty)
            {
                Expend();
            }
            Items[Count] = item;
            count++;

        }

        public void Inser(int index, T item)
        {
            if (index < 0 || index > Capacty)
            {
                throw new Exception("index out the range");
            }
            if (count == Capacty)
            {
                Expend();
            }
            for (int i = count ; i > index; i--)
            {
                Items[i] = Items[i - 1];
            }
            Items[index] = item;
            count++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > count-1)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            for (int i = index; i < count; i++)
            {
                Items[i] = Items[i + 1];
            }
            count--;
        }

        public int Searsh(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if (Items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Remove(T item)
        {
            int index = Searsh(item);
            if (index == -1)
            {
                Console.WriteLine($" Item {item} not found in list");

            }
            else
            {
                RemoveAt( index);
            }

        }



        public void print()
        {
          
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine( Items[i] );
              

            }
           
        }
    }
}
