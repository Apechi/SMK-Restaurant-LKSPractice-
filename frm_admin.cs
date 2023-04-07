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
    public partial class frm_admin : Form
    {
        public string name { get; set; }
        private formUtills fu = new formUtills();

        public frm_admin()
        {
            InitializeComponent();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            lbl_profile.Text = $"Welcome {name}";
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Gv.fm.Show();
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            Gv.fmm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            fu.formClosed(Gv.fa, Gv.fm, Gv.fmm, Gv.fc, Gv.fl, Gv.fo);
            Application.Exit();
            Application.Restart();
            this.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Gv.fo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}