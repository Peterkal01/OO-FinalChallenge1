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
    public class SelectedBorrowerController : ApiController
    {
        // GET: api/SelectedBorrower
        public IEnumerable<string> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<SelectedBorrower> output = new List<SelectedBorrower>();

            try
            {
                conn.Open();
                query = "SELECT Books.ISBN,Books.Title, Borrower.id,Borrower.Surname, Borrower.Firstname, Borrower.DOB FROM Books INNER JOIN Borrower  ON Books.Borrower = Borrower.id; ";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output.Add(new SelectedBorrower(Int32.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString(),
                        rdr.GetValue(2).ToString(),
                        rdr.GetValue(3).ToString(),
                        (new Books(Int32.Parse(rdr.GetValue(4).ToString()),
                        rdr.GetValue(5).ToString(),
                        (Int32.Parse(rdr.GetValue(6).ToString()),
                        (Int32.Parse(rdr.GetValue(7).ToString())))))));

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




        // POST: api/SelectedBorrower
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SelectedBorrower/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SelectedBorrower/5
        public void Delete(int id)
        {
        }
    }
}
