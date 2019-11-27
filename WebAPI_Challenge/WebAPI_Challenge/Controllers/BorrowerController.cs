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
    public class BorrowerController : ApiController
    {
        // GET: api/Borrower
        public IEnumerable<Borrower> Get()
        {
            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand cmd;
            SqlDataReader rdr;
            String query;
            List<Borrower> output = new List<Borrower>();

            try
            {
                conn.Open();                              
                query = "select * from borrower";
                cmd = new SqlCommand(query, conn);
                rdr = cmd.ExecuteReader();


                while (rdr.Read())

                {

                    output.Add(new Borrower(Int32.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString(),
                         rdr.GetValue(2).ToString(),
                          rdr.GetValue(3).ToString()));

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

        // GET: api/Borrower/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Borrower
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Borrower/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Borrower/5
        public void Delete(int id)
        {
        }
    }
}
