using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class Books
    {
        public int ISBN { get; set; }
        public string title { get; set; }
        public int borrower { get; set; }
        public int author { get; set; }

        public Books()
        {

        }
        public Books(int isbn, string bTitle, int bBorrower, int bAuthor)
        {
            ISBN = isbn;
            title = bTitle;
            borrower = bBorrower;
            author = bAuthor;
        }
    }
}