
namespace trivago
{
    partial class login
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_link = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customer_btn = new System.Windows.Forms.RadioButton();
            this.admin_btn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(130, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail or UserName ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(158, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.name_txt.Location = new System.Drawing.Point(348, 145);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(180, 26);
            this.name_txt.TabIndex = 2;
            this.name_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_txt_KeyPress);
            // 
            // password_txt
            // 
            this.password_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.password_txt.Location = new System.Drawing.Point(348, 201);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(180, 26);
            this.password_txt.TabIndex = 3;
            this.password_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_txt_KeyPress);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.login_btn.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Olive;
            this.login_btn.Location = new System.Drawing.Point(185, 395);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(157, 44);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "log-in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_link
            // 
            this.register_link.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.register_link.AutoSize = true;
            this.register_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_link.LinkColor = System.Drawing.Color.DarkOliveGreen;
            this.register_link.Location = new System.Drawing.Point(425, 406);
            this.register_link.Name = "register_link";
            this.register_link.Size = new System.Drawing.Size(165, 25);
            this.register_link.TabIndex = 6;
            this.register_link.TabStop = true;
            this.register_link.Text = "New Customer?";
            this.register_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DimGray;
            this.checkBox1.Location = new System.Drawing.Point(570, 204);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 25);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customer_btn);
            this.groupBox1.Controls.Add(this.admin_btn);
            this.groupBox1.Location = new System.Drawing.Point(310, 261);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // customer_btn
            // 
            this.customer_btn.AutoSize = true;
            this.customer_btn.Checked = true;
            this.customer_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.Color.DimGray;
            this.customer_btn.Location = new System.Drawing.Point(20, 64);
            this.customer_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(118, 25);
            this.customer_btn.TabIndex = 1;
            this.customer_btn.TabStop = true;
            this.customer_btn.Text = "Customer";
            this.customer_btn.UseVisualStyleBackColor = true;
            // 
            // admin_btn
            // 
            this.admin_btn.AutoSize = true;
            this.admin_btn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.ForeColor = System.Drawing.Color.DimGray;
            this.admin_btn.Location = new System.Drawing.Point(20, 21);
            this.admin_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(92, 25);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(329, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trivago";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.register_link);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "Trivago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.LinkLabel register_link;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton customer_btn;
        private System.Windows.Forms.RadioButton admin_btn;
        private System.Windows.Forms.Label label3;
    }
}

