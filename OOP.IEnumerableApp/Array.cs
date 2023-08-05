using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.IEnumerableApp
{
    public class Array : IEnumerable
    {
        private int[] InnerList { get; set; }
        private int index = 0;
        public Array(int size = 16)
        {
            InnerList = new int[size];
        }
        public Array(params int[] initial)
        {
            InnerList = new int[initial.Length];
            foreach (var item in initial)
            {
                InnerList[index++] = item;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return InnerList.Take(index).GetEnumerator();
        }
    }
}
