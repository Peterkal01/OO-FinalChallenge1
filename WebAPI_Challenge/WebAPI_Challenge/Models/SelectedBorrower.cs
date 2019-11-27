using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class SelectedBorrower
    {
        public int Id { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }
        public string DOB { get; set; }

        public virtual Books Books { get; set }

        public SelectedBorrower()
        {

        }
        public SelectedBorrower(int sbId, string sbSname, string sbFname, string sdob, Books sBooks)
        {
            Id = sbId;
            surname = sbSname;
            firstname = sbFname;
            DOB = sdob;
            Books = sBooks;
        }
    }
}

