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
    public class NotBorrowedController : ApiController
    {
        // GET: api/NotBorrowed
        public IEnumerable<NotBorrowed> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<NotBorrowed> output = new List<NotBorrowed>();

            try
            {
                conn.Open();
                query = "SELECT ISBN, Title from Books where Borrower is null";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output.Add(new NotBorrowed(Int32.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString()));
                        

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
        // POST: api/NotBorrowed
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NotBorrowed/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NotBorrowed/5
        public void Delete(int id)
        {
        }
    }
}
