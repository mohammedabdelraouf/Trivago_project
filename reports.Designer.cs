namespace trivago
{
    partial class reports
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
            this.cmb_hotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_hotel
            // 
            this.cmb_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_hotel.FormattingEnabled = true;
            this.cmb_hotel.Location = new System.Drawing.Point(93, 21);
            this.cmb_hotel.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_hotel.Name = "cmb_hotel";
            this.cmb_hotel.Size = new System.Drawing.Size(239, 32);
            this.cmb_hotel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_admin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_admin.Location = new System.Drawing.Point(360, 5);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(292, 62);
            this.btn_admin.TabIndex = 5;
            this.btn_admin.Text = "Generate admins report";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.Transparent;
            this.btn_customers.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_customers.Location = new System.Drawing.Point(1000, 5);
            this.btn_customers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(339, 62);
            this.btn_customers.TabIndex = 6;
            this.btn_customers.Text = "Generate customers report";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 75);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1383, 475);
            this.crystalReportViewer1.TabIndex = 7;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(765, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1400, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_hotel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reports";
            this.Text = "reports";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reports_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_hotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_customers;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
    }
}

