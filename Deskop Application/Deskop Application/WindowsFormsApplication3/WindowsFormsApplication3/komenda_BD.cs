using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public static class komenda_BD
    {
        public static void bd_klasa()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"server=DESKTOP-NF9GGJ7\Dazzyl; trusted_connection=false; database=ASG; User ID=sa; Password=lolek1234";
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
        }

    }
}
