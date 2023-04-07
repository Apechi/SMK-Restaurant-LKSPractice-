using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LATIHANMEMBUATCRUD
{
    public partial class frm_report : Form
    {
        private DataTable dt_reportTable = new DataTable();
        private DataTable dt_cbBox = new DataTable();
        private sqlComponent comp = new sqlComponent();
        private int cbfromX;
        private int cbtoX;

        public frm_report()
        {
            InitializeComponent();
        }

        public void fromToCB()
        {
            //dt_cbBox = comp.getSql("SELECT DISTINCT FORMAT(date, 'M/yyyy') as date FROM orderHeader ORDER BY date ASC");
            //foreach (DataRow row in dt_cbBox.Rows)
            //{
            //    DateTime tanggal = DateTime.Parse(row["date"].ToString());
            //    string tanggalFormatted = tanggal.ToString("MMMM", CultureInfo.InvariantCulture);
            //    cb_from.Items.Add(tanggalFormatted);
            //    cb_to.Items.Add(tanggalFormatted);
            //}

            string[] MonthName = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            for (int i = 0; i <= 11; i++)
            {
                string fullMonthName = MonthName[i];
                cb_from.Items.Add(fullMonthName);
                cb_to.Items.Add(fullMonthName);
            }

            //declare datatable dt
            //declare year
            //declare month
            //declare days
            //set dt = getsql select orderid from orderDetail
            //loop row in dt
            //    set year = dt get all row from dt then substring 4 digit from left
            //    set month = dt get all row from dt then substring 6 digit from left 4 digit from right
        }

        public void fromToValidate()
        {
            if (cbfromX > cbtoX)
            {
                btn_generate.Enabled = true;
            }
            else
            {
                Gv.Pesan($"Input tidak benar", false);
            }
        }

        public string getOmset(int month, int year)
        {
            string monthStr = month.ToString("D2"); //menambahkan 00 jika dibutuhkan
            string omset = "0";
            string maxDays;
            if (monthStr == "04" || monthStr == "06" || monthStr == "09" || monthStr == "11")
            {
                maxDays = "30";
            }
            else if (monthStr == "02")
            {
                maxDays = "29";
            }
            else
            {
                maxDays = "31";
            }
            var dt = Gv.dt = comp.getSql($"SELECT SUM(M.price * D.qty) as Omset FROM orderHeader H INNER JOIN orderDetail D ON D.orderid = H.id INNER JOIN MsMenu M On D.menuid = M.id WHERE H.date BETWEEN '{year}-{monthStr}-01' AND '{year}-{monthStr}-{maxDays}'");

            if (dt.Rows.Count > 0)
            {
                omset = dt.Rows[0][0].ToString();
            }
            return omset;
        }

        public void getReport()
        {
            string[] monthNames = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            int fromMonthCount = cbfromX;
            int toMonthCount = cbtoX;
            int fromYearCount = DateTime.Today.Year;
            int toYearCount = DateTime.Today.Year;

            if (toYearCount >= fromYearCount && toMonthCount >= fromMonthCount)
            {
                dgv_data.Rows.Clear();
                c_report.Series["Omset"].Points.Clear();

                for (int year = fromYearCount; year <= toYearCount; year++)
                {
                    int startMonth = year == fromYearCount ? fromMonthCount : 1;
                    int endMonth = year == toYearCount ? toMonthCount : 12;

                    for (int month = startMonth; month <= endMonth; month++)
                    {
                        string monthYear = string.Format("{0} {1}", monthNames[month - 1], year);
                        string omset = string.Format("Rp. {0:N0}, - ", getOmset(month, year));

                        dgv_data.Rows.Add(monthYear, omset);
                        c_report.Series["Omset"].Points.AddXY(monthNames[month - 1], getOmset(month, year));
                    }
                }
            }
            else
            {
                Gv.Pesan("Gagal Dapat Report", false);
            }
        }

        private void frm_report_Load(object sender, EventArgs e)
        {
            fromToCB();
        }

        private void cb_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromToValidate();
            var idx = int.Parse(cb_to.SelectedIndex.ToString()) + 1;
            cbtoX = idx;
            Console.WriteLine(cbtoX);
        }

        private void cb_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = int.Parse(cb_from.SelectedIndex.ToString()) + 1;
            cbfromX = idx;
            Console.WriteLine(cbfromX);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            getReport();
        }
    }
}