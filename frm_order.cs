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
        }
    }
}