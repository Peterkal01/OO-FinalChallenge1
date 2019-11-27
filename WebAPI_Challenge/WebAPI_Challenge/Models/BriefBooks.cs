using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class BriefBooks
    {
        public int ISBN { get; set; }
        public string title { get; set; }


        public BriefBooks()
        {

        }
        public BriefBooks(int isbn, string bTitle)
        {
            ISBN = isbn;
            title = bTitle;
        }
    }
}