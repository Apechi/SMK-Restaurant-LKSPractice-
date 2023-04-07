
namespace LATIHANMEMBUATCRUD
{
    partial class frm_report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.cb_to = new System.Windows.Forms.ComboBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.c_report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Bulan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_report)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // cb_from
            // 
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Location = new System.Drawing.Point(265, 81);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(260, 24);
            this.cb_from.TabIndex = 3;
            this.cb_from.SelectedIndexChanged += new System.EventHandler(this.cb_from_SelectedIndexChanged);
            // 
            // cb_to
            // 
            this.cb_to.FormattingEnabled = true;
            this.cb_to.Location = new System.Drawing.Point(265, 124);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(260, 24);
            this.cb_to.TabIndex = 4;
            this.cb_to.SelectedIndexChanged += new System.EventHandler(this.cb_to_SelectedIndexChanged);
            // 
            // btn_generate
            // 
            this.btn_generate.Enabled = false;
            this.btn_generate.Location = new System.Drawing.Point(556, 126);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(114, 36);
            this.btn_generate.TabIndex = 5;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bulan,
            this.Omset});
            this.dgv_data.Location = new System.Drawing.Point(34, 180);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(735, 209);
            this.dgv_data.TabIndex = 6;
            // 
            // c_report
            // 
            chartArea3.Name = "ChartArea1";
            this.c_report.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.c_report.Legends.Add(legend3);
            this.c_report.Location = new System.Drawing.Point(34, 417);
            this.c_report.Name = "c_report";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Omset";
            this.c_report.Series.Add(series3);
            this.c_report.Size = new System.Drawing.Size(735, 273);
            this.c_report.TabIndex = 7;
            this.c_report.Text = "chart1";
            // 
            // Bulan
            // 
            this.Bulan.HeaderText = "Bulan";
            this.Bulan.MinimumWidth = 6;
            this.Bulan.Name = "Bulan";
            this.Bulan.Width = 125;
            // 
            // Omset
            // 
            this.Omset.HeaderText = "Omset";
            this.Omset.MinimumWidth = 6;
            this.Omset.Name = "Omset";
            this.Omset.Width = 125;
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.c_report);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.cb_to);
            this.Controls.Add(this.cb_from);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_report";
            this.Text = "frm_report";
            this.Load += new System.EventHandler(this.frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_from;
        private System.Windows.Forms.ComboBox cb_to;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bulan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omset;
    }
}