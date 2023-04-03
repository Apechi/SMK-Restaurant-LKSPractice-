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
    class Gv
    {

        public static DataTable userData;
        public static String  formActive;
        public static String statusProcess;
        public static string hakAkses;
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F316BRT\SQLEXPRESS;Initial Catalog=db_restoran;Integrated Security=True");
        public static SqlDataAdapter da;
        public static DataTable dt;
        public static SqlCommand cmd;

        public static void Pesan(String x, Boolean y) {

            if (y)
            {
                MessageBox.Show(x, "Informasi",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
            } else 
            {
                MessageBox.Show(x, "Warning",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
            }

            
        }


    }
}
