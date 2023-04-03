using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LATIHANMEMBUATCRUD
{
    public partial class frm_login : Form
    {
        public frm_admin admin_form = new frm_admin();
        public frm_cashier cashier = new frm_cashier();
        public frm_crudMenu menu = new frm_crudMenu();
        public frm_manageMember member = new frm_manageMember();

        private sqlComponent comp = new sqlComponent();

        public frm_login()
        {
            InitializeComponent();
        }

        public void login()
        {
            string email = tb_email.Text;
            string password = tb_password.Text;

            try
            {
                string query = "SELECT * FROM MsEmployee WHERE email = '" + email + "' AND password = '" + password + "'";

                Gv.da = new SqlDataAdapter(query, Gv.con);
                var dt = Gv.dt = new DataTable();
                Gv.da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0][1].ToString();
                    if (dt.Rows[0][5].ToString() == "admin")
                    {
                        admin_form = new frm_admin();
                        admin_form.name = name;
                        admin_form.Show();
                    }
                    else if (dt.Rows[0][5].ToString() == "cashier")
                    {
                        cashier = new frm_cashier();
                        cashier.name = name;
                        cashier.Show();
                    }
                    this.Hide();
                    Console.WriteLine("berhasil, " + name + "");
                }
            }
            catch (Exception ex)
            {
                Gv.Pesan("Maaf, data yang di masukkan salah", false);
            }
            finally
            {
                Gv.con.Close();
            }
        }

        public void formClosed(params Form[] form)
        {
            foreach (Form f in form)
            {
                f.Close();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            formClosed(admin_form, member, menu, cashier);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}