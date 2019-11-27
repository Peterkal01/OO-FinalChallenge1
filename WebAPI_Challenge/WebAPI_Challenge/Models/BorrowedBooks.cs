using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class BorrowedBooks
    {
        public int ISBN { get; set; }
        public string title { get; set; }      
        
        public virtual Borrower Borrower { get; set; }

        public BorrowedBooks()
        {

        }
        public BorrowedBooks(int bbisbn, string bbTitle, Borrower bBorrower)
        {
            ISBN = bbisbn;
            title = bbTitle;
   
            Borrower = bBorrower;
        }
    }
}