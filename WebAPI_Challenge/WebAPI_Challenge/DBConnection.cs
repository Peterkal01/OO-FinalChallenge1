using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;



namespace WebAPI_Challenge

{

    public static class DBConnection

    {

        public static SqlConnection GetConnection()
        {
            string ConnString = @"Server=civapi.database.windows.net;Database=civapi;User ID=civ_user;Password=Monday1330;";
            return new SqlConnection(ConnString);
        }



    }

}