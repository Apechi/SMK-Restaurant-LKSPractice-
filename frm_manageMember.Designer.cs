
namespace LATIHANMEMBUATCRUD
{
    partial class frm_manageMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_member = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_handphone = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_input = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).BeginInit();
            this.gb_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            // 
            // dgv_member
            // 
            this.dgv_member.AllowUserToAddRows = false;
            this.dgv_member.AllowUserToDeleteRows = false;
            this.dgv_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_member.Location = new System.Drawing.Point(13, 71);
            this.dgv_member.Name = "dgv_member";
            this.dgv_member.RowHeadersWidth = 51;
            this.dgv_member.RowTemplate.Height = 24;
            this.dgv_member.Size = new System.Drawing.Size(775, 200);
            this.dgv_member.TabIndex = 2;
            this.dgv_member.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_member_MouseClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(13, 286);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(138, 22);
            this.tb_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(157, 286);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(114, 34);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(168, 22);
            this.tb_id.TabIndex = 5;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(114, 62);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(168, 22);
            this.tb_name.TabIndex = 6;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(114, 90);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(168, 22);
            this.tb_email.TabIndex = 7;
            // 
            // tb_handphone
            // 
            this.tb_handphone.Location = new System.Drawing.Point(114, 118);
            this.tb_handphone.Name = "tb_handphone";
            this.tb_handphone.Size = new System.Drawing.Size(168, 22);
            this.tb_handphone.TabIndex = 8;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(265, 463);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(79, 35);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(350, 463);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(79, 35);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(435, 463);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 35);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(304, 463);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 35);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(389, 463);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 35);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "menuid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "no.Handphone";
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.tb_id);
            this.gb_input.Controls.Add(this.label5);
            this.gb_input.Controls.Add(this.label4);
            this.gb_input.Controls.Add(this.label1);
            this.gb_input.Controls.Add(this.label3);
            this.gb_input.Controls.Add(this.tb_name);
            this.gb_input.Controls.Add(this.tb_email);
            this.gb_input.Controls.Add(this.tb_handphone);
            this.gb_input.Location = new System.Drawing.Point(500, 286);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(288, 160);
            this.gb_input.TabIndex = 18;
            this.gb_input.TabStop = false;
            this.gb_input.Text = "groupBox1";
            // 
            // frm_manageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_member);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_input);
            this.Name = "frm_manageMember";
            this.Text = "manageMember";
            this.Load += new System.EventHandler(this.frm_manageMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_member)).EndInit();
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_member;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_handphone;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_input;
    }
}