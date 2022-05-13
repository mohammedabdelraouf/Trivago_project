namespace trivago
{
    partial class ChangeReservation
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
            this.hotel_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_buttun = new System.Windows.Forms.Button();
            this.room_cmb = new System.Windows.Forms.ComboBox();
            this.res_data = new System.Windows.Forms.DataGridView();
            this.resid_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.total_cost_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.res_data)).BeginInit();
            this.SuspendLayout();
            // 
            // hotel_txt
            // 
            this.hotel_txt.Enabled = false;
            this.hotel_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotel_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hotel_txt.Location = new System.Drawing.Point(471, 437);
            this.hotel_txt.Name = "hotel_txt";
            this.hotel_txt.ReadOnly = true;
            this.hotel_txt.Size = new System.Drawing.Size(121, 26);
            this.hotel_txt.TabIndex = 1;
            // 
            // price_txt
            // 
            this.price_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.price_txt.Location = new System.Drawing.Point(753, 439);
            this.price_txt.Name = "price_txt";
            this.price_txt.ReadOnly = true;
            this.price_txt.Size = new System.Drawing.Size(121, 26);
            this.price_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hotel Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "price ";
            // 
            // delete_buttun
            // 
            this.delete_buttun.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_buttun.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.delete_buttun.Location = new System.Drawing.Point(376, 570);
            this.delete_buttun.Name = "delete_buttun";
            this.delete_buttun.Size = new System.Drawing.Size(252, 39);
            this.delete_buttun.TabIndex = 6;
            this.delete_buttun.Text = "Delete Reservation";
            this.delete_buttun.UseVisualStyleBackColor = true;
            this.delete_buttun.Click += new System.EventHandler(this.delete_buttun_Click);
            // 
            // room_cmb
            // 
            this.room_cmb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_cmb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.room_cmb.FormattingEnabled = true;
            this.room_cmb.Location = new System.Drawing.Point(185, 434);
            this.room_cmb.Name = "room_cmb";
            this.room_cmb.Size = new System.Drawing.Size(121, 26);
            this.room_cmb.TabIndex = 7;
            this.room_cmb.SelectedIndexChanged += new System.EventHandler(this.room_cmb_SelectedIndexChanged);
            // 
            // res_data
            // 
            this.res_data.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.res_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.res_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.res_data.Enabled = false;
            this.res_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.res_data.Location = new System.Drawing.Point(185, 91);
            this.res_data.Name = "res_data";
            this.res_data.RowHeadersWidth = 51;
            this.res_data.RowTemplate.Height = 24;
            this.res_data.Size = new System.Drawing.Size(562, 209);
            this.res_data.TabIndex = 8;
            // 
            // resid_cmb
            // 
            this.resid_cmb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resid_cmb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.resid_cmb.FormattingEnabled = true;
            this.resid_cmb.Location = new System.Drawing.Point(185, 520);
            this.resid_cmb.Name = "resid_cmb";
            this.resid_cmb.Size = new System.Drawing.Size(121, 26);
            this.resid_cmb.TabIndex = 9;
            this.resid_cmb.SelectedIndexChanged += new System.EventHandler(this.resid_cmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "reservation ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(753, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(372, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Your Reservations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(372, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Choose Room To Delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "cost";
            // 
            // total_cost_txt
            // 
            this.total_cost_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_cost_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.total_cost_txt.Location = new System.Drawing.Point(471, 520);
            this.total_cost_txt.Name = "total_cost_txt";
            this.total_cost_txt.ReadOnly = true;
            this.total_cost_txt.Size = new System.Drawing.Size(121, 26);
            this.total_cost_txt.TabIndex = 16;
            // 
            // ChangeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 650);
            this.Controls.Add(this.total_cost_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resid_cmb);
            this.Controls.Add(this.res_data);
            this.Controls.Add(this.room_cmb);
            this.Controls.Add(this.delete_buttun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.hotel_txt);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Name = "ChangeReservation";
            this.Text = "ChangeReservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeReservation_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeReservation_FormClosed);
            this.Load += new System.EventHandler(this.ChangeReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.res_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hotel_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_buttun;
        private System.Windows.Forms.ComboBox room_cmb;
        private System.Windows.Forms.DataGridView res_data;
        private System.Windows.Forms.ComboBox resid_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox total_cost_txt;
    }
}