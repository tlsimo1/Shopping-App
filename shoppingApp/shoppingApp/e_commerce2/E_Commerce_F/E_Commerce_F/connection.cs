using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce_F
{
    public class connection
    {
        SqlConnection con = new SqlConnection(@"Data Source=USER-PC\agitech;Initial Catalog=BIJOU;Integrated Security=True");

        public SqlConnection Active()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
    }
}