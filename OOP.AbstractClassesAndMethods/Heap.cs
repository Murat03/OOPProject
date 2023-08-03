using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClassesAndMethods
{
    public abstract class Heap
    {
        protected SortedSet<int> _list;
        public Heap()
        {
            _list = new SortedSet<int>();
        }
        public void Insert(int item)
        {
            _list.Add(item);
        }
        public abstract int Extract();
    }
}
