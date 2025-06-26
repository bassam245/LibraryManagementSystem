using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mange
{
    internal class Book
    {
        public string Tittle;
        public string Auther;
        public int BookId;
        public bool IsIssued;
        public Book(string Tittle, string Auther, int BookId)
        {
            this.Tittle = Tittle;
            this.Auther = Auther;
            this.BookId = BookId;
            IsIssued = false;
        }
        // representation  the book date
        public override string ToString()
        {
            return $"Tittle off book : {Tittle.PadRight(14)} || Auther Name : {Auther.PadRight(10)} || BookId : {BookId.ToString().PadRight(10)} || IsIssued : {IsIssued.ToString().PadRight(10)}";

        }
    }
}
