
namespace LATIHANMEMBUATCRUD
{
    partial class frm_admin
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
            this.lbl_profile = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_member = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Navigation";
            // 
            // lbl_profile
            // 
            this.lbl_profile.AutoSize = true;
            this.lbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_profile.Location = new System.Drawing.Point(52, 133);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(170, 25);
            this.lbl_profile.TabIndex = 1;
            this.lbl_profile.Text = "Welcome, [admin]";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(311, 183);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(148, 53);
            this.btn_order.TabIndex = 2;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(311, 254);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(148, 53);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Manage Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_member
            // 
            this.btn_member.Location = new System.Drawing.Point(311, 324);
            this.btn_member.Name = "btn_member";
            this.btn_member.Size = new System.Drawing.Size(148, 53);
            this.btn_member.TabIndex = 4;
            this.btn_member.Text = "Manage Member";
            this.btn_member.UseVisualStyleBackColor = true;
            this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(311, 398);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(148, 53);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_member);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.lbl_profile);
            this.Controls.Add(this.label1);
            this.Name = "frm_admin";
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_member;
        private System.Windows.Forms.Button btn_logout;
    }
}