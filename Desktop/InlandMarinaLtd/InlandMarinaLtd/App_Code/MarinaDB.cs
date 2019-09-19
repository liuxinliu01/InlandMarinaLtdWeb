using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InlandMarinaLtd.App_Code
{
    public static class MarinaDB
    {
        public static SqlConnection GetConnection()
        {
            string connectingString = @"Data Source=localhost\sqlexpress;Initial Catalog=Marina;Integrated Security=True";
            return new SqlConnection(connectingString);
        }


    }
}