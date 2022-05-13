using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace trivago
{
    public  partial class registeration : Form
    {
       

        OracleConnection conn;

        public registeration()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(manage_app.ordb);
            conn.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandType = CommandType.Text;
            c.CommandText = "select NATIONALITYNAME from NATIONALITY";

            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                nationality_cmb.Items.Add(dr[0]);
            }

            dr.Close();
        }

       
        private void nationality_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select NATIONALITYKEY from NATIONALITY where NATIONALITYNAME = :Nname";
            c.Parameters.Add("Nname", nationality_cmb.SelectedItem);

            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                NatKey_txt.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            if (name_txt.Text == "" || phone_txt.Text == "" || nationality_cmb.SelectedItem.ToString() == "" ||
                password_txt.Text == "" || password_confirm_txt.Text == "")
            {
                MessageBox.Show("Please Enter Full Data");
            }
            else
            {
                int cid, new_cid;
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandType = CommandType.StoredProcedure;
                c.CommandText = "get_cid";
                c.Parameters.Add("cid", OracleDbType.Int32, ParameterDirection.Output);
                c.ExecuteNonQuery();
                try
                {
                    cid = Convert.ToInt32(c.Parameters["cid"].Value.ToString());
                    new_cid = cid + 1;
                }
                catch
                {
                    new_cid = 1;
                }

                bool validation = true;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into customers values(:n, :customername, :nationality, :phonenumber, :gender, :Email , :Password ,20000)";

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("n", new_cid);
                cmd.Parameters.Add("customername", name_txt.Text.ToString());
                cmd.Parameters.Add("nationality", nationality_cmb.SelectedItem.ToString());
                string gender = "";
                if (radioButton1.Checked == true)
                {
                    gender = "M";
                }
                else if (radioButton2.Checked == true)
                {
                    gender = "F";
                }
                else
                {
                    validation = false;
                    MessageBox.Show("please select gender");
                }
                cmd.Parameters.Add("phonenumber", phone_txt.Text);
                cmd.Parameters.Add("gender", gender);
                cmd.Parameters.Add("Email", name_txt.Text + "@cust.com");

                string password = "";
                if (password_txt.Text == password_confirm_txt.Text)
                {
                    password = password_txt.Text;
                }
                else
                {
                    validation = false;
                    MessageBox.Show("not the same password");
                }

                cmd.Parameters.Add("Password", password);
                if (validation == true)
                {
                    try
                    {
                        int r = cmd.ExecuteNonQuery();
                        if (r != -1)
                        {

                            MessageBox.Show("sucsess now you can log in");
                            manage_app.login.Show();
                            this.Hide();
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }

        }
        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            manage_app.login.Show();
            this.Hide();
        }


        private void show1_box_CheckedChanged_1(object sender, EventArgs e)
        {

            if (password_txt.PasswordChar != '*')
            {
                password_txt.PasswordChar = '*';
            }
            else if (password_txt.PasswordChar == '*')
            {
                password_txt.PasswordChar = (char)0;
            }
        }

        private void show2_box_CheckedChanged_1(object sender, EventArgs e)
        {
            if (password_confirm_txt.PasswordChar != '*')
            {
                password_confirm_txt.PasswordChar = '*';
            }
            else if (password_confirm_txt.PasswordChar == '*')
            {
                password_confirm_txt.PasswordChar = (char)0;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            Application.Exit();
        }

    
    }
}
