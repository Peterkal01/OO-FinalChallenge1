using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Challenge.Models;

namespace WebAPI_Challenge.Controllers
{
    public class BorrowedBooksController : ApiController
    {
        // GET: api/BorrowedBooks
        public IEnumerable<BorrowedBooks> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<BorrowedBooks> output = new List<BorrowedBooks>();

            try
            {
                conn.Open();
                query = "SELECT Books.ISBN,Books.Title, Borrower.id,Borrower.Surname, Borrower.Firstname, Borrower.DOB FROM Books INNER JOIN Borrower  ON Books.Borrower = Borrower.id; ";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output.Add(new BorrowedBooks(Int32.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString(),                       
                        (new Borrower(Int32.Parse(rdr.GetValue(2).ToString()),
                        rdr.GetValue(3).ToString(),
                         rdr.GetValue(4).ToString(),
                          rdr.GetValue(5).ToString()))));
                       
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return output;
        }








        // POST: api/BorrowedBooks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BorrowedBooks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BorrowedBooks/5
        public void Delete(int id)
        {
        }
    }
}
