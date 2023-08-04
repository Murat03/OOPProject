using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.ICloneableApp
{
    public class Book : ICloneable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public object Clone()
        {
            ////deep copy
            //var book = new Book();
            //book.Id = Id;
            //book.Title = Title;
            //book.Price = Price;
            //return book;

            //shallow copy
            return MemberwiseClone();
        }
    }
}
