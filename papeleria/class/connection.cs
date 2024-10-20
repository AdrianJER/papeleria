using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papeleria
{
    public class connection
    {
        static SqlConnection con;

        public static void connect()
        {
            con = new SqlConnection("Data Source=localhost;Initial Catalog=papeleria;Integrated Security=True;");
            con.Open();
        }
        public static void disconnect()
        {
            con.Close();
            con = null;
        }
        public static DataTable query(string query)
        {
            DataTable dt = new DataTable();
            connect();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            disconnect();
            return dt;
        }
    }
}
