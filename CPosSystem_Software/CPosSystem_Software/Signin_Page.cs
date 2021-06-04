using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPosSystem_Software
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String Username = txt_username.Text;
            String Password = txt_password.Text;

            DBConnection obj = new DBConnection();
            obj.Connection();

            if(Username != "" && Password !="")
            {
                String SQL = "SELECT * FROM Stafftb WHERE Mem_UN = '" + Username + "' AND Mem_PW = '" + Password + "';";
                obj.cmd = new SqlCommand(SQL,obj.conn);
                obj.dr = obj.cmd.ExecuteReader();

                if (obj.dr.Read())
                {
                    MessageBox.Show("Login Successful..!", "Infromation: Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard_Page window = new Dashboard_Page();
                    window.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check Username and Password", "Error: Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Please Enter Username and Password", "Error: Login", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
