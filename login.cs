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
    public  partial class login : Form
    {
        OracleConnection conn;
        public login()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(manage_app.ordb);
            conn.Open();
            
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            manage_app.registeration.Show();
            this.Hide();
           
        }

       

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_function();
            
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                login_function();

            }
        }

        private void name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                login_function();


            }
           
        }

        private void password_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                login_function();

            }
            
        }


      

       

        private void login_function()
        {

            OracleCommand cmd = new OracleCommand();
            if (name_txt.Text == "" || password_txt.Text == "")
            {
                MessageBox.Show("missing data entery");
            }
            else
            {

                if (admin_btn.Checked)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select email, password, adminid , ADMINENAME from Admins where email = :email or ADMINENAME = :an and password = :password";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("email", name_txt.Text);
                    cmd.Parameters.Add("an", name_txt.Text);
                    cmd.Parameters.Add("pasword", password_txt.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        manage_app.AdminEmail = dr[0].ToString();
                        manage_app.admin_id = dr[2].ToString();
                        manage_app.admin_name = dr[3].ToString();

                        admin_page p = new admin_page();
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password");

                    }
                }
                else if (customer_btn.Checked)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select email, password, customerid  ,PHONENUMBER , CUSTOMERNAME , cridit from Customers where( email = :email  or CUSTOMERNAME= :cn ) and password = :password";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("email", name_txt.Text);
                    cmd.Parameters.Add("cn", name_txt.Text);
                    cmd.Parameters.Add("pasword", password_txt.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        manage_app.customer_email = dr[0].ToString();
                        manage_app.customer_id = dr[2].ToString();
                        manage_app.customer_name = dr[4].ToString();
                        manage_app.customer_phone = dr[3].ToString();
                        manage_app.customer_balance = Convert.ToInt32(dr[5].ToString());
                        name_txt.Text = "";
                        password_txt.Text ="";
                        manage_app.reservation.Refresh();
                        manage_app.reservation.Show();


                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name Or Password");


                    }
                }
                else
                {
                    MessageBox.Show("Please Choose Customer Or Admin");


                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            Application.Exit();
        }
    }
}
