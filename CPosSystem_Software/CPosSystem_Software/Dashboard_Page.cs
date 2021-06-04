using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPosSystem_Software
{
    public partial class Dashboard_Page : Form
    {
        public Dashboard_Page()
        {
            InitializeComponent();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            Invoice_Page window = new Invoice_Page();
            window.Show();
            this.Hide();
        }
    }
}
