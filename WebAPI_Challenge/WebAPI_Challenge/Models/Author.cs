using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Challenge.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string surname { get; set; }
        public string firstname { get; set; }

        public Author()
        {

        }
        public Author(int aId, string aSame, string aFname)
        {
            Id = aId;
            surname = aSame;
            firstname = aFname;
        }
    }
}