
namespace LATIHANMEMBUATCRUD
{
    partial class frm_payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_orderID = new System.Windows.Forms.ComboBox();
            this.cb_pt = new System.Windows.Forms.ComboBox();
            this.cb_bank = new System.Windows.Forms.ComboBox();
            this.tb_cn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_card = new System.Windows.Forms.Label();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_orderdetail = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "orderId";
            // 
            // cb_orderID
            // 
            this.cb_orderID.FormattingEnabled = true;
            this.cb_orderID.Location = new System.Drawing.Point(295, 80);
            this.cb_orderID.Name = "cb_orderID";
            this.cb_orderID.Size = new System.Drawing.Size(188, 24);
            this.cb_orderID.TabIndex = 2;
            this.cb_orderID.SelectedValueChanged += new System.EventHandler(this.cb_orderID_SelectedValueChanged);
            // 
            // cb_pt
            // 
            this.cb_pt.FormattingEnabled = true;
            this.cb_pt.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.cb_pt.Location = new System.Drawing.Point(295, 338);
            this.cb_pt.Name = "cb_pt";
            this.cb_pt.Size = new System.Drawing.Size(188, 24);
            this.cb_pt.TabIndex = 3;
            this.cb_pt.SelectedValueChanged += new System.EventHandler(this.cb_pt_SelectedValueChanged);
            // 
            // cb_bank
            // 
            this.cb_bank.FormattingEnabled = true;
            this.cb_bank.Items.AddRange(new object[] {
            "Bank Mandiri",
            "BCA",
            "BRI",
            "BNI",
            "Bank Danamon"});
            this.cb_bank.Location = new System.Drawing.Point(295, 417);
            this.cb_bank.Name = "cb_bank";
            this.cb_bank.Size = new System.Drawing.Size(188, 24);
            this.cb_bank.TabIndex = 5;
            // 
            // tb_cn
            // 
            this.tb_cn.Location = new System.Drawing.Point(296, 379);
            this.tb_cn.Name = "tb_cn";
            this.tb_cn.Size = new System.Drawing.Size(187, 22);
            this.tb_cn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payment Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_card
            // 
            this.lbl_card.AutoSize = true;
            this.lbl_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card.Location = new System.Drawing.Point(168, 381);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(109, 20);
            this.lbl_card.TabIndex = 8;
            this.lbl_card.Text = "Card Number";
            // 
            // lbl_bank
            // 
            this.lbl_bank.AutoSize = true;
            this.lbl_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bank.Location = new System.Drawing.Point(181, 421);
            this.lbl_bank.Name = "lbl_bank";
            this.lbl_bank.Size = new System.Drawing.Size(96, 20);
            this.lbl_bank.TabIndex = 9;
            this.lbl_bank.Text = "Bank Name";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(337, 465);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 32);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_orderdetail
            // 
            this.dgv_orderdetail.AllowUserToAddRows = false;
            this.dgv_orderdetail.AllowUserToDeleteRows = false;
            this.dgv_orderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderdetail.Location = new System.Drawing.Point(12, 124);
            this.dgv_orderdetail.Name = "dgv_orderdetail";
            this.dgv_orderdetail.RowHeadersWidth = 51;
            this.dgv_orderdetail.RowTemplate.Height = 24;
            this.dgv_orderdetail.Size = new System.Drawing.Size(776, 196);
            this.dgv_orderdetail.TabIndex = 11;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(644, 338);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 18);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "Total:";
            // 
            // frm_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_orderdetail);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_bank);
            this.Controls.Add(this.lbl_card);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cn);
            this.Controls.Add(this.cb_bank);
            this.Controls.Add(this.cb_pt);
            this.Controls.Add(this.cb_orderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_payment";
            this.Text = "frm_payment";
            this.Load += new System.EventHandler(this.frm_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_orderID;
        private System.Windows.Forms.ComboBox cb_pt;
        private System.Windows.Forms.ComboBox cb_bank;
        private System.Windows.Forms.TextBox tb_cn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_card;
        private System.Windows.Forms.Label lbl_bank;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_orderdetail;
        private System.Windows.Forms.Label lbl_total;
    }
}