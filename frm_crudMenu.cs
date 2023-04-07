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

using System.Data;

namespace LATIHANMEMBUATCRUD
{
    public partial class frm_crudMenu : Form
    {
        public frm_crudMenu()
        {
            InitializeComponent();
        }

        private sqlComponent comp = new sqlComponent();
        private String imgLoc = "";

        public void formRefresh()
        {
            dgv_menu.DataSource = comp.getSql("SELECT id, name, price, carbo, protein, photo FROM MsMenu");
            dgv_menu.Columns["photo"].Visible = false;
        }

        public void mainButtonActive()
        {
            btn_cancel.Visible = false;
            btn_save.Visible = false;
            gb_input.Enabled = false;

            btn_update.Visible = true;
            btn_insert.Visible = true;
            btn_delete.Visible = true;
        }

        public void scButtonActive()
        {
            btn_cancel.Visible = true;
            btn_save.Visible = true;
            gb_input.Enabled = true;

            btn_update.Visible = false;
            btn_insert.Visible = false;
            btn_delete.Visible = false;
        }

        public bool inputRules()
        {
            if (tb_name.Text == "" || tb_price.Text == "" || tb_carbo.Text == "" || tb_protein.Text == "")
            {
                MessageBox.Show("Data Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void crudController(string status)
        {
            string[] menu = new string[] { tb_menuID.Text, tb_name.Text, tb_price.Text, imgLoc, tb_carbo.Text, tb_protein.Text };
            Boolean result = false;
            if (status == "delete")
            {
                comp.setSql($"DELETE FROM MsMenu WHERE id = '{tb_menuID.Text}'");
            }
            else if (status == "insert")
            {
                if (inputRules())
                {
                    result = comp.manageMenuController(status, menu);
                }
            }
            else if (status == "update")
            {
                if (inputRules())
                {
                    result = comp.manageMenuController(status, menu);
                }
            }
            if (status == "search")
            {
                dgv_menu.DataSource = comp.getSql($"SELECT * FROM MsMenu WHERE name LIKE '%{tb_search.Text}%' OR price LIKE '%{tb_search.Text}%' OR protein LIKE '%{tb_search.Text}%' OR carbo LIKE '%{tb_search.Text}%'");
                result = true;
            }
            if (!result)
            {
                formRefresh();
                Gv.Pesan("Berhasil", true);
                mainButtonActive();
                clearTB();
                mainButtonState(false);
            }
        }

        private void clearTB()
        {
            tb_menuID.Text = "";
            tb_name.Text = "";
            tb_price.Text = "";
            tb_photo.Text = "";
            tb_carbo.Text = "";
            tb_protein.Text = "";
        }

        private void mainButtonState(bool state)
        {
            btn_update.Enabled = state;
            btn_delete.Enabled = state;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formRefresh();
            clearTB();
            mainButtonState(false);
            mainButtonActive();
        }

        private void dgv_menu_MouseClick(object sender, MouseEventArgs e)
        {
            mainButtonActive();

            if (dgv_menu.Rows.Count != 0)
            {
                int x = dgv_menu.CurrentRow.Index;
                tb_menuID.Text = dgv_menu.Rows[x].Cells[0].Value.ToString();
                tb_name.Text = dgv_menu.Rows[x].Cells[1].Value.ToString();
                tb_price.Text = dgv_menu.Rows[x].Cells[2].Value.ToString();
                tb_carbo.Text = dgv_menu.Rows[x].Cells[3].Value.ToString();
                tb_protein.Text = dgv_menu.Rows[x].Cells[4].Value.ToString();
                string imageShow = dgv_menu.Rows[x].Cells[5].Value.ToString();
                string imageName = tb_menuID.Text;
                byte[] imageBytes = comp.displayImg(imageName);
                if (imageShow != null && imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pb_menu.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pb_menu.Image = null;
                }
                mainButtonState(true);
            }
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png ) | *.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imgLoc = open.FileName;
                pb_menu.ImageLocation = imgLoc;
                tb_photo.Text = imgLoc;
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Gv.statusProcess = "insert";
            scButtonActive();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Gv.statusProcess = "update";
            scButtonActive();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Gv.statusProcess = "delete";
            scButtonActive();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            crudController(Gv.statusProcess);
            formRefresh();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mainButtonActive();
            clearTB();
            mainButtonState(false);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            crudController("search");
        }
    }
}