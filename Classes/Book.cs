using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje1.Classes
{
    public class Book
    {
        public int? Id;

        public string Title;
        public string Author;
        public enum Size
        {
            Large = 1,
            Small = 2,
        }
        public int BookSize { get; set; }
        public Book() { }

        public Book(Size size)
        {
            BookSize = (int)size;
        }

        

    }
}
