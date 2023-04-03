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
            dgv_order.DataSource = comp.getSql("SELECT MsMenu.name AS 'Menu', orderDetail.qty, MsMenu.carbo, MsMenu.protein, MsMenu.Price FROM orderDetail JOIN MsMenu ON orderDetail.orderid = MsMenu.id");
            MenuAddInputState(false, false);
        }

        public void MenuAddInputState(bool state, bool delete)
        {
            gb_input.Enabled = state;
            btn_add.Enabled = state;
            btn_delete.Enabled = delete;
        }

        public void addOrder(string status)
        {
            if (dgv_menu.Rows.Count > 0)
            {
                if (status == "add")
                {
                }
            }
        }

        private void dgv_menu_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_menu.Rows.Count > 0)
            {
                int x = dgv_menu.CurrentRow.Index;
                tb_menuId.Text = dgv_menu.Rows[x].Cells[0].Value.ToString();
                tb_menu.Text = dgv_menu.Rows[x].Cells[1].Value.ToString();
                string imageShow = dgv_menu.Rows[x].Cells[3].Value.ToString();
                if (imageShow != null && comp.displayImg(dgv_menu.Rows[dgv_menu.CurrentRow.Index].Cells[0].Value.ToString()) != null)
                {
                    MemoryStream ms = new MemoryStream(comp.displayImg(dgv_menu.Rows[dgv_menu.CurrentRow.Index].Cells[0].Value.ToString()));
                    if (ms != null)
                    {
                        pb_image.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pb_image.Image = null;
                    }
                }
                MenuAddInputState(true, false);
            }
        }
    }
}