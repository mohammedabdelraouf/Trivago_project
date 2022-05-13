
namespace trivago
{
    partial class reservation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservation));
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hotels_cmb = new System.Windows.Forms.ComboBox();
            this.rooms_cmb = new System.Windows.Forms.ComboBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_rooms_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acount_info = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataSet11 = new trivago.DataSet1();
            this.account_box = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.balance_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hide_btn = new System.Windows.Forms.Button();
            this.cust_ID = new System.Windows.Forms.Label();
            this.cust_phone = new System.Windows.Forms.Label();
            this.cust_Email = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cost_txt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.account_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(174, 102);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(111, 20);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Hotel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rooms Available";
            // 
            // hotels_cmb
            // 
            this.hotels_cmb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotels_cmb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hotels_cmb.FormattingEnabled = true;
            this.hotels_cmb.Location = new System.Drawing.Point(305, 97);
            this.hotels_cmb.Name = "hotels_cmb";
            this.hotels_cmb.Size = new System.Drawing.Size(167, 26);
            this.hotels_cmb.TabIndex = 2;
            // 
            // rooms_cmb
            // 
            this.rooms_cmb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms_cmb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.rooms_cmb.FormattingEnabled = true;
            this.rooms_cmb.Location = new System.Drawing.Point(267, 386);
            this.rooms_cmb.Name = "rooms_cmb";
            this.rooms_cmb.Size = new System.Drawing.Size(167, 26);
            this.rooms_cmb.TabIndex = 3;
            this.rooms_cmb.SelectedIndexChanged += new System.EventHandler(this.rooms_cmb_SelectedIndexChanged);
            // 
            // price_txt
            // 
            this.price_txt.Enabled = false;
            this.price_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.price_txt.Location = new System.Drawing.Point(522, 380);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 26);
            this.price_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // show_rooms_btn
            // 
            this.show_rooms_btn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_rooms_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.show_rooms_btn.Location = new System.Drawing.Point(305, 301);
            this.show_rooms_btn.Name = "show_rooms_btn";
            this.show_rooms_btn.Size = new System.Drawing.Size(286, 36);
            this.show_rooms_btn.TabIndex = 6;
            this.show_rooms_btn.Text = "Show Available Rooms";
            this.show_rooms_btn.UseVisualStyleBackColor = true;
            this.show_rooms_btn.Click += new System.EventHandler(this.show_rooms_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 31);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMyReservationToolStripMenuItem,
            this.acount_info});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // viewMyReservationToolStripMenuItem
            // 
            this.viewMyReservationToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMyReservationToolStripMenuItem.Name = "viewMyReservationToolStripMenuItem";
            this.viewMyReservationToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.viewMyReservationToolStripMenuItem.Text = "Chang My Reservation";
            this.viewMyReservationToolStripMenuItem.Click += new System.EventHandler(this.viewMyReservationToolStripMenuItem_Click);
            // 
            // acount_info
            // 
            this.acount_info.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acount_info.Name = "acount_info";
            this.acount_info.Size = new System.Drawing.Size(259, 26);
            this.acount_info.Text = "View My Information ";
            this.acount_info.Click += new System.EventHandler(this.viewMyAccountToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(543, 485);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 26);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "End Date";
            // 
            // start_date
            // 
            this.start_date.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.CalendarForeColor = System.Drawing.Color.DarkOliveGreen;
            this.start_date.Location = new System.Drawing.Point(305, 162);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(275, 22);
            this.start_date.TabIndex = 12;
            // 
            // end_date
            // 
            this.end_date.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.CalendarForeColor = System.Drawing.Color.DarkOliveGreen;
            this.end_date.Location = new System.Drawing.Point(305, 234);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(275, 22);
            this.end_date.TabIndex = 13;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.submit_btn.Location = new System.Drawing.Point(323, 480);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(111, 35);
            this.submit_btn.TabIndex = 14;
            this.submit_btn.Text = "submit ";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OliveDrab;
            this.label5.Location = new System.Drawing.Point(299, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reservation Form ";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // account_box
            // 
            this.account_box.Controls.Add(this.label9);
            this.account_box.Controls.Add(this.balance_txt);
            this.account_box.Controls.Add(this.label8);
            this.account_box.Controls.Add(this.label7);
            this.account_box.Controls.Add(this.label6);
            this.account_box.Controls.Add(this.hide_btn);
            this.account_box.Controls.Add(this.cust_ID);
            this.account_box.Controls.Add(this.cust_phone);
            this.account_box.Controls.Add(this.cust_Email);
            this.account_box.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_box.Location = new System.Drawing.Point(12, 67);
            this.account_box.Name = "account_box";
            this.account_box.Size = new System.Drawing.Size(348, 362);
            this.account_box.TabIndex = 17;
            this.account_box.TabStop = false;
            this.account_box.Text = "Acount Informations";
            this.account_box.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "your balance :";
            // 
            // balance_txt
            // 
            this.balance_txt.AutoSize = true;
            this.balance_txt.Location = new System.Drawing.Point(159, 202);
            this.balance_txt.Name = "balance_txt";
            this.balance_txt.Size = new System.Drawing.Size(28, 18);
            this.balance_txt.TabIndex = 19;
            this.balance_txt.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "your ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "phone number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email : ";
            // 
            // hide_btn
            // 
            this.hide_btn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hide_btn.Location = new System.Drawing.Point(242, 285);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(90, 36);
            this.hide_btn.TabIndex = 18;
            this.hide_btn.Text = "hide";
            this.hide_btn.UseVisualStyleBackColor = true;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // cust_ID
            // 
            this.cust_ID.AutoSize = true;
            this.cust_ID.Location = new System.Drawing.Point(159, 151);
            this.cust_ID.Name = "cust_ID";
            this.cust_ID.Size = new System.Drawing.Size(28, 18);
            this.cust_ID.TabIndex = 2;
            this.cust_ID.Text = "00";
            // 
            // cust_phone
            // 
            this.cust_phone.AutoSize = true;
            this.cust_phone.Location = new System.Drawing.Point(159, 106);
            this.cust_phone.Name = "cust_phone";
            this.cust_phone.Size = new System.Drawing.Size(28, 18);
            this.cust_phone.TabIndex = 1;
            this.cust_phone.Text = "00";
            // 
            // cust_Email
            // 
            this.cust_Email.AutoSize = true;
            this.cust_Email.Location = new System.Drawing.Point(157, 59);
            this.cust_Email.Name = "cust_Email";
            this.cust_Email.Size = new System.Drawing.Size(28, 18);
            this.cust_Email.TabIndex = 0;
            this.cust_Email.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(464, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "total cost";
            // 
            // cost_txt
            // 
            this.cost_txt.Enabled = false;
            this.cost_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cost_txt.Location = new System.Drawing.Point(574, 427);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(100, 26);
            this.cost_txt.TabIndex = 20;
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 594);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.account_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.show_rooms_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.rooms_cmb);
            this.Controls.Add(this.hotels_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "reservation";
            this.Text = "Reservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.reservation_FormClosed);
            this.Load += new System.EventHandler(this.reservation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.account_box.ResumeLayout(false);
            this.account_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hotels_cmb;
        private System.Windows.Forms.ComboBox rooms_cmb;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_rooms_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acount_info;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label5;
        private DataSet1 dataSet11;
        private System.Windows.Forms.GroupBox account_box;
        private System.Windows.Forms.Button hide_btn;
        private System.Windows.Forms.Label cust_ID;
        private System.Windows.Forms.Label cust_phone;
        private System.Windows.Forms.Label cust_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label balance_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cost_txt;
    }
}