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

namespace LATIHANMEMBUATCRUD
{
    public partial class frm_order : Form
    {
        private sqlComponent comp = new sqlComponent();
        private formUtills fu = new formUtills();
        private int dgvOrderIndex = 0;
        private DataTable dtMember;

        public frm_order()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void frm_order_Load(object sender, EventArgs e)
        {
            dgv_menu.DataSource = comp.getSql("SELECT * FROM MsMenu");
            dgv_menu.Columns["photo"].Visible = false;
            gb_input.Enabled = true;
            btn_add.Enabled = true;
            memberId();
        }

        public void addOrder()
        {
            try
            {
                int qty = int.Parse(tb_qty.Text);
                string menu = tb_menu.Text;
                int price = int.Parse(tb_price.Text) * qty;
                int carbo = int.Parse(tb_carbo.Text) * qty;
                int protein = int.Parse(tb_protein.Text) * qty;
                int total = price * qty;

                DataGridViewRow rowExist = dgv_order.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => r.Cells["Menu"].Value?.ToString() == menu);
                if (rowExist != null)
                {
                    int newQty = int.Parse(rowExist.Cells["Qty"].Value.ToString()) + qty;
                    int newCarbo = carbo * newQty;
                    int newProtein = protein * newQty;
                    int newTotal = price * newQty;

                    rowExist.Cells["Qty"].Value = newQty;
                    rowExist.Cells["Carbo"].Value = newCarbo;
                    rowExist.Cells["Protein"].Value = newProtein;
                    rowExist.Cells["Total"].Value = newTotal;
                }
                else
                {
                    dgv_order.Rows.Add(menu, qty, price, carbo, protein, total);
                }
            }
            catch (Exception ex)
            {
                Gv.Pesan("Data harus di isi", false);
            }
        }

        private void memberId()
        {
            dtMember = comp.getSql("SELECT * FROM MsMember ORDER BY name");
            foreach (DataRow row in dtMember.Rows)
            {
                string name = row["name"].ToString();
                cb_member.Items.Add(name);
            }
        }

        private void updateTotal()
        {
            int total = 0;
            int karbo = 0;
            int protein = 0;
            if (dgv_order.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_order.Rows)
                {
                    int totals = (int)row.Cells[5].Value;
                    int proteins = (int)row.Cells[3].Value;
                    int carbos = (int)row.Cells[4].Value;

                    total += totals;
                    protein += proteins;
                    karbo += carbos;
                }

                lbl_total.Text = $"Total : {total}";
                lbl_protein.Text = $"Protein : {protein}";
                lbl_carbo.Text = $"Karbo : {karbo}";
            }
            else
            {
                lbl_total.Text = $"Total : {total}";
                lbl_protein.Text = $"Protein : {protein}";
                lbl_carbo.Text = $"Karbo : {karbo}";
            }
        }

        private void dgv_menu_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_menu.Rows.Count > 0)
            {
                int x = dgv_menu.CurrentRow.Index;
                tb_menuId.Text = dgv_menu.Rows[x].Cells[0].Value.ToString();
                tb_menu.Text = dgv_menu.Rows[x].Cells[1].Value.ToString();
                tb_price.Text = dgv_menu.Rows[x].Cells[2].Value.ToString();
                tb_carbo.Text = dgv_menu.Rows[x].Cells[4].Value.ToString();
                tb_protein.Text = dgv_menu.Rows[x].Cells[5].Value.ToString();
                string imageShow = dgv_menu.Rows[x].Cells[3].Value.ToString();
                string imageName = tb_menuId.Text;
                byte[] imageBytes = comp.displayImg(imageName);
                if (imageShow != null && imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pb_image.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_image.Image = null;
                }
                gb_input.Enabled = true;
                btn_add.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addOrder();
            updateTotal();
        }

        private void dgv_order_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_order.Rows.Count > 0)
            {
                dgvOrderIndex = dgv_order.CurrentRow.Index;
                btn_delete.Enabled = true;
                updateTotal();
            }
        }

        private void dgv_order_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void dgv_order_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_order.Rows.Count > 0)
            {
                dgv_order.Rows.RemoveAt(dgvOrderIndex);
                btn_delete.Enabled = false;
                updateTotal();
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_order.Rows.Count > 0)
                {
                    string orderID = comp.orderId();
                    bool result = false;
                    result = comp.setSql($"INSERT INTO orderHeader (id, employeeid, memberid, date) VALUES ('{orderID}', '{Gv.userData}' {(!string.IsNullOrWhiteSpace(tb_memberId.Text) ? $",{tb_memberId.Text}" : ",1")}, '{DateTime.Today.ToString("yyyy-MM-dd")}')");
                    if (result)
                    {
                        foreach (DataGridViewRow row in dgv_order.Rows)
                        {
                            Gv.dt = comp.getSql($"SELECT * FROM MsMenu WHERE name = '{row.Cells[0].Value}'");
                            result = comp.setSql($"INSERT INTO orderDetail(orderid, menuid, qty, status) VALUES ('{orderID}', '{Gv.dt.Rows[0][0]}','{row.Cells[1].Value}', 'Memasak') ");
                        }
                        if (result)
                        {
                            Gv.Pesan($"Pesanan nomor {orderID} sedang dibuat, harap tunggu", true);
                            dgv_order.Rows.Clear();
                        }
                    }
                }
            }
            catch { }
        }

        private void cb_member_SelectedValueChanged(object sender, EventArgs e)
        {
            int idIndex = cb_member.SelectedIndex;
            tb_memberId.Text = dtMember.Rows[idIndex][0].ToString();
        }
    }
}