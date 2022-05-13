namespace trivago
{
    partial class admin_page
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
            this.What = new System.Windows.Forms.GroupBox();
            this.room_radio = new System.Windows.Forms.RadioButton();
            this.hotel_radio = new System.Windows.Forms.RadioButton();
            this.customer_radio = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Grid_view = new System.Windows.Forms.DataGridView();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.Admin_txt = new System.Windows.Forms.Label();
            this.show_reports_btn = new System.Windows.Forms.Button();
            this.What.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // What
            // 
            this.What.Controls.Add(this.room_radio);
            this.What.Controls.Add(this.hotel_radio);
            this.What.Controls.Add(this.customer_radio);
            this.What.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.What.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.What.Location = new System.Drawing.Point(209, 76);
            this.What.Name = "What";
            this.What.Size = new System.Drawing.Size(453, 123);
            this.What.TabIndex = 0;
            this.What.TabStop = false;
            this.What.Text = "Show Data For?";
            // 
            // room_radio
            // 
            this.room_radio.AutoSize = true;
            this.room_radio.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_radio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.room_radio.Location = new System.Drawing.Point(184, 62);
            this.room_radio.Name = "room_radio";
            this.room_radio.Size = new System.Drawing.Size(83, 22);
            this.room_radio.TabIndex = 2;
            this.room_radio.TabStop = true;
            this.room_radio.Text = "Rooms";
            this.room_radio.UseVisualStyleBackColor = true;
            // 
            // hotel_radio
            // 
            this.hotel_radio.AutoSize = true;
            this.hotel_radio.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotel_radio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hotel_radio.Location = new System.Drawing.Point(358, 62);
            this.hotel_radio.Name = "hotel_radio";
            this.hotel_radio.Size = new System.Drawing.Size(81, 22);
            this.hotel_radio.TabIndex = 1;
            this.hotel_radio.TabStop = true;
            this.hotel_radio.Text = "Hotels";
            this.hotel_radio.UseVisualStyleBackColor = true;
            // 
            // customer_radio
            // 
            this.customer_radio.AutoSize = true;
            this.customer_radio.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_radio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.customer_radio.Location = new System.Drawing.Point(6, 62);
            this.customer_radio.Name = "customer_radio";
            this.customer_radio.Size = new System.Drawing.Size(113, 22);
            this.customer_radio.TabIndex = 0;
            this.customer_radio.TabStop = true;
            this.customer_radio.Text = "Customers";
            this.customer_radio.UseVisualStyleBackColor = true;
            // 
            // Grid_view
            // 
            this.Grid_view.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.Grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_view.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grid_view.Location = new System.Drawing.Point(92, 248);
            this.Grid_view.Name = "Grid_view";
            this.Grid_view.RowHeadersWidth = 51;
            this.Grid_view.RowTemplate.Height = 24;
            this.Grid_view.Size = new System.Drawing.Size(719, 289);
            this.Grid_view.TabIndex = 1;
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.load_button.Location = new System.Drawing.Point(312, 205);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(212, 37);
            this.load_button.TabIndex = 2;
            this.load_button.Text = "Load Informations";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.save_button.Location = new System.Drawing.Point(748, 553);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(149, 38);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // log_out
            // 
            this.log_out.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.log_out.Location = new System.Drawing.Point(380, 543);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(108, 48);
            this.log_out.TabIndex = 8;
            this.log_out.Text = "log out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // Admin_txt
            // 
            this.Admin_txt.AutoSize = true;
            this.Admin_txt.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_txt.ForeColor = System.Drawing.Color.OliveDrab;
            this.Admin_txt.Location = new System.Drawing.Point(307, 32);
            this.Admin_txt.Name = "Admin_txt";
            this.Admin_txt.Size = new System.Drawing.Size(0, 29);
            this.Admin_txt.TabIndex = 10;
            // 
            // show_reports_btn
            // 
            this.show_reports_btn.Location = new System.Drawing.Point(12, 12);
            this.show_reports_btn.Name = "show_reports_btn";
            this.show_reports_btn.Size = new System.Drawing.Size(141, 61);
            this.show_reports_btn.TabIndex = 11;
            this.show_reports_btn.Text = "show reports";
            this.show_reports_btn.UseVisualStyleBackColor = true;
            this.show_reports_btn.Click += new System.EventHandler(this.show_reports_btn_Click);
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 614);
            this.Controls.Add(this.show_reports_btn);
            this.Controls.Add(this.Admin_txt);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.Grid_view);
            this.Controls.Add(this.What);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Name = "admin_page";
            this.Text = "Manage Data";
            this.Activated += new System.EventHandler(this.admin_page_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.admin_page_FormClosed);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.What.ResumeLayout(false);
            this.What.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox What;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton room_radio;
        private System.Windows.Forms.RadioButton hotel_radio;
        private System.Windows.Forms.RadioButton customer_radio;
        private System.Windows.Forms.DataGridView Grid_view;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Label Admin_txt;
        private System.Windows.Forms.Button show_reports_btn;
    }
}