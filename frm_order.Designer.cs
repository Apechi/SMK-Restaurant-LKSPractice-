
namespace LATIHANMEMBUATCRUD
{
    partial class frm_order
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
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.tb_menu = new System.Windows.Forms.TextBox();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbl_carbo = new System.Windows.Forms.Label();
            this.lbl_protein = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.tb_menuId = new System.Windows.Forms.TextBox();
            this.tb_orderID = new System.Windows.Forms.TextBox();
            this.tb_orderHeaderId = new System.Windows.Forms.TextBox();
            this.tb_menuidOrder = new System.Windows.Forms.TextBox();
            this.tb_qtyOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.gb_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Order";
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.AllowUserToDeleteRows = false;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(12, 66);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.RowHeadersWidth = 51;
            this.dgv_menu.RowTemplate.Height = 24;
            this.dgv_menu.Size = new System.Drawing.Size(776, 175);
            this.dgv_menu.TabIndex = 1;
            this.dgv_menu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_menu_MouseClick);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(73, 266);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(213, 174);
            this.pb_image.TabIndex = 2;
            this.pb_image.TabStop = false;
            // 
            // tb_menu
            // 
            this.tb_menu.Enabled = false;
            this.tb_menu.Location = new System.Drawing.Point(137, 14);
            this.tb_menu.Name = "tb_menu";
            this.tb_menu.Size = new System.Drawing.Size(159, 22);
            this.tb_menu.TabIndex = 3;
            // 
            // tb_qty
            // 
            this.tb_qty.Location = new System.Drawing.Point(137, 52);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(159, 22);
            this.tb_qty.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "QTY";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(381, 387);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 32);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(525, 387);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(127, 32);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.AllowUserToDeleteRows = false;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(12, 459);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersWidth = 51;
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.Size = new System.Drawing.Size(776, 175);
            this.dgv_order.TabIndex = 9;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(341, 654);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(127, 32);
            this.btn_order.TabIndex = 10;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // lbl_carbo
            // 
            this.lbl_carbo.AutoSize = true;
            this.lbl_carbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carbo.Location = new System.Drawing.Point(12, 654);
            this.lbl_carbo.Name = "lbl_carbo";
            this.lbl_carbo.Size = new System.Drawing.Size(77, 25);
            this.lbl_carbo.TabIndex = 11;
            this.lbl_carbo.Text = "Carbo: ";
            // 
            // lbl_protein
            // 
            this.lbl_protein.AutoSize = true;
            this.lbl_protein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_protein.Location = new System.Drawing.Point(127, 655);
            this.lbl_protein.Name = "lbl_protein";
            this.lbl_protein.Size = new System.Drawing.Size(79, 25);
            this.lbl_protein.TabIndex = 12;
            this.lbl_protein.Text = "Protein:";
            this.lbl_protein.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(611, 654);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 25);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Total:";
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.label3);
            this.gb_input.Controls.Add(this.label2);
            this.gb_input.Controls.Add(this.tb_qty);
            this.gb_input.Controls.Add(this.tb_menu);
            this.gb_input.Location = new System.Drawing.Point(314, 255);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(311, 89);
            this.gb_input.TabIndex = 14;
            this.gb_input.TabStop = false;
            this.gb_input.Text = "";
            // 
            // tb_menuId
            // 
            this.tb_menuId.Enabled = false;
            this.tb_menuId.Location = new System.Drawing.Point(631, 270);
            this.tb_menuId.Name = "tb_menuId";
            this.tb_menuId.Size = new System.Drawing.Size(55, 22);
            this.tb_menuId.TabIndex = 15;
            // 
            // tb_orderID
            // 
            this.tb_orderID.Enabled = false;
            this.tb_orderID.Location = new System.Drawing.Point(314, 431);
            this.tb_orderID.Name = "tb_orderID";
            this.tb_orderID.Size = new System.Drawing.Size(55, 22);
            this.tb_orderID.TabIndex = 16;
            // 
            // tb_orderHeaderId
            // 
            this.tb_orderHeaderId.Enabled = false;
            this.tb_orderHeaderId.Location = new System.Drawing.Point(375, 431);
            this.tb_orderHeaderId.Name = "tb_orderHeaderId";
            this.tb_orderHeaderId.Size = new System.Drawing.Size(55, 22);
            this.tb_orderHeaderId.TabIndex = 17;
            // 
            // tb_menuidOrder
            // 
            this.tb_menuidOrder.Enabled = false;
            this.tb_menuidOrder.Location = new System.Drawing.Point(436, 431);
            this.tb_menuidOrder.Name = "tb_menuidOrder";
            this.tb_menuidOrder.Size = new System.Drawing.Size(55, 22);
            this.tb_menuidOrder.TabIndex = 18;
            // 
            // tb_qtyOrder
            // 
            this.tb_qtyOrder.Enabled = false;
            this.tb_qtyOrder.Location = new System.Drawing.Point(497, 431);
            this.tb_qtyOrder.Name = "tb_qtyOrder";
            this.tb_qtyOrder.Size = new System.Drawing.Size(55, 22);
            this.tb_qtyOrder.TabIndex = 19;
            // 
            // frm_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 740);
            this.Controls.Add(this.tb_qtyOrder);
            this.Controls.Add(this.tb_menuidOrder);
            this.Controls.Add(this.tb_orderHeaderId);
            this.Controls.Add(this.tb_orderID);
            this.Controls.Add(this.tb_menuId);
            this.Controls.Add(this.gb_input);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_protein);
            this.Controls.Add(this.lbl_carbo);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.dgv_menu);
            this.Controls.Add(this.label1);
            this.Name = "frm_order";
            this.Text = "frm_order";
            this.Load += new System.EventHandler(this.frm_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.TextBox tb_menu;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_carbo;
        private System.Windows.Forms.Label lbl_protein;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.TextBox tb_menuId;
        private System.Windows.Forms.TextBox tb_orderID;
        private System.Windows.Forms.TextBox tb_orderHeaderId;
        private System.Windows.Forms.TextBox tb_menuidOrder;
        private System.Windows.Forms.TextBox tb_qtyOrder;
    }
}