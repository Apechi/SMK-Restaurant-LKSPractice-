
namespace LATIHANMEMBUATCRUD
{
    partial class frm_crudMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_protein = new System.Windows.Forms.TextBox();
            this.tb_carbo = new System.Windows.Forms.TextBox();
            this.tb_photo = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_menuID = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(559, 581);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(139, 50);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Add Data";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.btn_image);
            this.gb_input.Controls.Add(this.label6);
            this.gb_input.Controls.Add(this.label7);
            this.gb_input.Controls.Add(this.label8);
            this.gb_input.Controls.Add(this.label5);
            this.gb_input.Controls.Add(this.label4);
            this.gb_input.Controls.Add(this.label3);
            this.gb_input.Controls.Add(this.tb_protein);
            this.gb_input.Controls.Add(this.tb_carbo);
            this.gb_input.Controls.Add(this.tb_photo);
            this.gb_input.Controls.Add(this.tb_price);
            this.gb_input.Controls.Add(this.tb_name);
            this.gb_input.Controls.Add(this.tb_menuID);
            this.gb_input.Location = new System.Drawing.Point(92, 344);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(334, 287);
            this.gb_input.TabIndex = 14;
            this.gb_input.TabStop = false;
            this.gb_input.Text = "groupBox1";
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(259, 142);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(44, 23);
            this.btn_image.TabIndex = 14;
            this.btn_image.Text = "...";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Protein";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Carbo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Photo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "MenuID";
            // 
            // tb_protein
            // 
            this.tb_protein.Location = new System.Drawing.Point(114, 219);
            this.tb_protein.Name = "tb_protein";
            this.tb_protein.Size = new System.Drawing.Size(189, 22);
            this.tb_protein.TabIndex = 6;
            // 
            // tb_carbo
            // 
            this.tb_carbo.Location = new System.Drawing.Point(114, 180);
            this.tb_carbo.Name = "tb_carbo";
            this.tb_carbo.Size = new System.Drawing.Size(189, 22);
            this.tb_carbo.TabIndex = 5;
            // 
            // tb_photo
            // 
            this.tb_photo.Location = new System.Drawing.Point(114, 142);
            this.tb_photo.Name = "tb_photo";
            this.tb_photo.Size = new System.Drawing.Size(140, 22);
            this.tb_photo.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(114, 104);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(189, 22);
            this.tb_price.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(114, 65);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(189, 22);
            this.tb_name.TabIndex = 2;
            // 
            // tb_menuID
            // 
            this.tb_menuID.AllowDrop = true;
            this.tb_menuID.Enabled = false;
            this.tb_menuID.Location = new System.Drawing.Point(114, 27);
            this.tb_menuID.Name = "tb_menuID";
            this.tb_menuID.Size = new System.Drawing.Size(189, 22);
            this.tb_menuID.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(722, 581);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 50);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Edit Data";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.AllowUserToDeleteRows = false;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(16, 66);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.ReadOnly = true;
            this.dgv_menu.RowHeadersWidth = 51;
            this.dgv_menu.RowTemplate.Height = 24;
            this.dgv_menu.Size = new System.Drawing.Size(1017, 233);
            this.dgv_menu.TabIndex = 0;
            this.dgv_menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_menu_MouseClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(875, 581);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 50);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete Data";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pb_menu
            // 
            this.pb_menu.Location = new System.Drawing.Point(704, 329);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Size = new System.Drawing.Size(176, 202);
            this.pb_menu.TabIndex = 18;
            this.pb_menu.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(779, 27);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(170, 22);
            this.tb_search.TabIndex = 20;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(955, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(92, 43);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(653, 581);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 50);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(816, 581);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(133, 50);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.pb_menu);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.dgv_menu);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.gb_input);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 634);
            this.panel1.TabIndex = 19;
            // 
            // frm_crudMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_crudMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_protein;
        private System.Windows.Forms.TextBox tb_carbo;
        private System.Windows.Forms.TextBox tb_photo;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_menuID;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
    }
}

