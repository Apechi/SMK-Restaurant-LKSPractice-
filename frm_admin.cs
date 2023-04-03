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
        public frm_admin()
        {
            InitializeComponent();
           

    }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            lbl_profile.Text = "Welcome " + name.ToString() + "";
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            frm_crudMenu menu = new frm_crudMenu();
            menu.Show();
           
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            frm_manageMember member = new frm_manageMember();
            member.Show();
          
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Close();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

        }
    }
}
