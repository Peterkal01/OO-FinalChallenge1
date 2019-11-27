using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class Borrower 
    {
        public int Id { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        public string DOB { get; set; }

        public Borrower()
        {

        }
        public Borrower(int bId, string bSname, string bFname, string dob)
        {
            Id = bId;
            surname = bSname;
            firstname = bFname;
            DOB = dob;
        }
    }
}
    
