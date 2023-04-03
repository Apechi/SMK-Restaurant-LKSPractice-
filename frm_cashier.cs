using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LATIHANMEMBUATCRUD
{
    public partial class frm_cashier : Form
    {
        public string name { get; set; }
        public frm_cashier()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_cashier_Load(object sender, EventArgs e)
        {
            lbl_profile.Text = "Welcome, " + name.ToString() + "";

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Close();
        }
    }
}
