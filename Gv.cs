using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LATIHANMEMBUATCRUD
{
    internal class Gv
    {
        public static String userData; //declare string userData
        public static String formActive;
        public static String statusProcess; //declare string status process for crud
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F316BRT\SQLEXPRESS;Initial Catalog=db_restoran;Integrated Security=True"); //declare connection
        public static SqlDataAdapter da; //declare data adapter without making a new instance
        public static DataTable dt; //declare data table
        public static SqlCommand cmd; //declare sql command cmd
        public static frm_admin fa = new frm_admin();
        public static frm_cashier fc = new frm_cashier();
        public static frm_crudMenu fm = new frm_crudMenu();
        public static frm_login fl = new frm_login();
        public static frm_manageMember fmm = new frm_manageMember();
        public static frm_order fo = new frm_order();
        public static frm_payment fp = new frm_payment();

        public static void Pesan(String x, Boolean y)
        {
            if (y)
            {
                MessageBox.Show(x, "Informasi",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(x, "Warning",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}