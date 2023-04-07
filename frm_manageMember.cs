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
    public partial class frm_manageMember : Form
    {
        private sqlComponent comp = new sqlComponent();
        private formUtills fu = new formUtills();

        public frm_manageMember()
        {
            InitializeComponent();
        }

        public void formRefresh()
        {
            dgv_member.DataSource = comp.getSql("SELECT * FROM MsMember");
        }

        private void frm_manageMember_Load(object sender, EventArgs e)
        {
            formRefresh();
            fu.clearTB(tb_email, tb_handphone, tb_id, tb_name, tb_search);
            fu.mainButtonState(false, btn_update, btn_delete);
            mainButtonActive();
        }

        public void crudController(string status)
        {
            Boolean result = false;

            if (status == "insert")
            {
                comp.setSql($"INSERT INTO MsMember (name, email, handphone) VALUES ('{tb_name.Text  }', '{ tb_email.Text } ', '{  tb_handphone.Text  }')");
                result = false;
            }
            else if (status == "delete")
            {
                DialogResult dialogResult = MessageBox.Show("Anda Yakin Ingin Menghapus Datanya?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    comp.setSql("DELETE * FROM MsMember WHERE id = '" + tb_id.Text + "' ");
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            else if (status == "update")
            {
                comp.setSql($"UPDATE MsMember SET name = '{tb_name.Text }', email = '{ tb_email.Text }', handphone =  '{ tb_handphone.Text }' WHERE id = { tb_id.Text }  ");
                result = false;
            }
            else if (status == "search")
            {
                dgv_member.DataSource = comp.getSql("SELECT * FROM MsMember WHERE name LIKE '%" + tb_search.Text + "%' OR email LIKE '%" + tb_search.Text + "%' OR handphone LIKE '%" + tb_search.Text + "%' ");
                result = true;
            }
            if (!result)
            {
                formRefresh();
                Gv.Pesan("Berhasil", true);
                fu.clearTB(tb_email, tb_handphone, tb_id, tb_name, tb_search);
                fu.mainButtonState(false, btn_update, btn_delete);
                mainButtonActive();
            }
        }

        private void mainButtonActive()
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            fu.clearTB(tb_email, tb_handphone, tb_id, tb_name, tb_search);
            fu.mainButtonState(false, btn_update, btn_delete);
            mainButtonActive();
        }

        private void dgv_member_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgv_member.Rows.Count != 0)
            {
                int x = dgv_member.CurrentRow.Index;
                tb_id.Text = dgv_member.Rows[x].Cells[0].Value.ToString();
                tb_name.Text = dgv_member.Rows[x].Cells[1].Value.ToString();
                tb_email.Text = dgv_member.Rows[x].Cells[2].Value.ToString();
                tb_handphone.Text = dgv_member.Rows[x].Cells[3].Value.ToString();
                fu.mainButtonState(true, btn_update, btn_delete);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Gv.statusProcess = "insert";
            scButtonActive();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Gv.statusProcess = "insert";
            scButtonActive();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Gv.statusProcess = "update";
            scButtonActive();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            crudController(Gv.statusProcess);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            crudController("search");
        }
    }
}