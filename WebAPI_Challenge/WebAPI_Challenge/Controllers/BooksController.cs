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
    public class BooksController : ApiController
    {
        // GET: api/Books
        public IEnumerable<BriefBooks> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<BriefBooks> output = new List<BriefBooks>();

            try
            {
                conn.Open();
                query = "select * from Books";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    output.Add(new BriefBooks(Int32.Parse(rdr.GetValue(0).ToString()),
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

        // GET: api/Books/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Books
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Books/5
        public void Delete(int id)
        {
        }
    }
}

