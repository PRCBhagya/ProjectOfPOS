using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPosSystem_Software
{
    class DBConnection
    {
        public string constring = "Data Source=localhost;Initial Catalog=possystem;Persist Security Info=True;User ID=sa;Password=1234";

        public SqlConnection conn = null;
        public SqlCommand cmd;
        public SqlDataReader dr;

        public void Connection()
        {
            conn = new SqlConnection(constring);

            conn.Open();

            if(conn.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Database connection fail..! Please contact operation team.", "Error: Database Connection",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

    }
}
