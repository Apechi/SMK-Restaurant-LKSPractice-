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
        private formUtills fu = new formUtills();

        public frm_cashier()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void frm_cashier_Load(object sender, EventArgs e)
        {
            lbl_profile.Text = $"Welcome,  {name}";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            fu.formClosed(Gv.fa, Gv.fm, Gv.fmm, Gv.fc, Gv.fl, Gv.fo);
            Application.Exit();
            Application.Restart();
            this.Close();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            Gv.fp.Show();
        }
    }
}