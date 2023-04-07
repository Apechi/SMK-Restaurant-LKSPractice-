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
    public partial class frm_payment : Form
    {
        private sqlComponent comp = new sqlComponent();
        private DataTable dtOrderID = new DataTable();
        private DataTable dt_orderDetail = new DataTable();
        private string tipePembayaran;
        private int totalharga;

        public frm_payment()
        {
            InitializeComponent();
        }

        private void orderID()
        {
            dtOrderID = comp.getSql($"SELECT DISTINCT orderHeader.id AS id FROM orderHeader JOIN orderDetail ON orderDetail.orderid = orderHeader.id WHERE orderDetail.status = 'Memasak' ORDER BY orderHeader.id");
            cb_orderID.Items.Clear();
            foreach (DataRow row in dtOrderID.Rows)
            {
                string id = row["id"].ToString();
                cb_orderID.Items.Add(id);
            }
        }

        private DataTable getTotal()
        {
            int total;
            int totalAll = 0;
            dt_orderDetail.Columns.Add("Total", typeof(int));
            foreach (DataRow row in dt_orderDetail.Rows)
            {
                var price = int.Parse(row["Price"].ToString());
                var qty = int.Parse(row["Qty"].ToString());
                total = price * qty;
                totalAll += total;
                row["Total"] = total.ToString();
            }

            dgv_orderdetail.Refresh();
            return dt_orderDetail;
        }

        private void updateTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in dgv_orderdetail.Rows)
            {
                var price = int.Parse(row.Cells[3].Value.ToString());
                total += price;
            }
            totalharga = total;
            lbl_total.Text = $"Total: Rp {totalharga.ToString("N", new CultureInfo("is-IS"))}";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void frm_payment_Load(object sender, EventArgs e)
        {
            formRefresh();
        }

        public void formRefresh()
        {
            orderID();
            btn_save.Enabled = false;
            cb_pt.SelectedItem = "Credit Card";
        }

        private void cb_orderID_SelectedValueChanged(object sender, EventArgs e)
        {
            int OIDindex = cb_orderID.SelectedIndex;
            string OID = dtOrderID.Rows[OIDindex][0].ToString();
            dt_orderDetail = comp.getSql($"SELECT MsMenu.name AS 'Menu', orderDetail.qty AS 'Qty', MsMenu.price AS 'Price' FROM orderDetail JOIN MsMenu ON orderDetail.menuid = MsMenu.id WHERE orderid = '{OID}'");
            if (dt_orderDetail.Rows.Count > 0)
            {
                dgv_orderdetail.DataSource = getTotal();
                updateTotal();
                btn_save.Enabled = true;
            }
            else
            {
                Console.WriteLine("lah");
            }
        }

        public void kembalian()
        {
            var total = totalharga;
            var bayar = tb_cn.Text;
            var bayarValue = int.Parse(bayar);
            if (bayarValue > total)
            {
                var kembalian = bayarValue - total;
                Gv.Pesan($"Kembalian:  Rp{kembalian.ToString("N", new CultureInfo("is-IS"))}", true);
            }
            else if (bayarValue < total)
            {
                Gv.Pesan($"Pembayaran Kurang", true);
            }
            else
            {
                Gv.Pesan($"Terimakasi Sudah Membeli", true);
            }
        }

        private void cb_pt_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_pt.SelectedItem.ToString() == "Cash")
            {
                tipePembayaran = "Cash";
                cb_bank.Visible = false;
                lbl_bank.Visible = false;
                lbl_card.Text = "Bayar";
            }
            else if (cb_pt.SelectedItem.ToString() == "Credit Card")
            {
                tipePembayaran = "Credit";
                cb_bank.Visible = true;
                lbl_bank.Visible = true;
                lbl_card.Text = "Credit Card";
            }
        }

        public bool cekKosong()
        {
            if (tb_cn.Text == "")
            {
                Gv.Pesan("Input Harus Di Isi", false);
                return false;
            }
            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipePembayaran == "Cash")
                {
                    if (cekKosong())
                    {
                        kembalian();
                        comp.setSql($"UPDATE orderHeader SET paymentType = '{tipePembayaran}'  WHERE id = '{ cb_orderID.SelectedItem }'");
                        comp.setSql($"UPDATE orderDetail SET status = 'Terbayar' WHERE orderid = '{ cb_orderID.SelectedItem }' ");
                        formRefresh();
                    }
                }
                if (tipePembayaran == "Credit")
                {
                    if (cekKosong() && cb_bank.SelectedItem != null)
                    {
                        comp.setSql($"UPDATE orderHeader SET paymentType = '{tipePembayaran}', cardNumber = '{tb_cn.Text}', bank = '{cb_bank.SelectedItem}' WHERE id = '{ cb_orderID.SelectedItem }' ");
                        comp.setSql($"UPDATE orderDetail SET status = 'Terbayar' WHERE orderid = '{ cb_orderID.SelectedItem }' ");
                        Console.WriteLine("tesberhasil");
                        formRefresh();
                    }
                }
                dt_orderDetail = new DataTable();
                dgv_orderdetail.DataSource = dt_orderDetail;
            }
            catch
            {
                Gv.Pesan("Gagal", false);
            }
        }
    }
}