using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class NotBorrowed
    {
        public int ISBN { get; set; }
        public string title { get; set; }

       

        public NotBorrowed()
        {

        }
        public NotBorrowed(int nbisbn, string nbTitle)
        {
            ISBN = nbisbn;
            title = nbTitle;

           
        }
    }
}