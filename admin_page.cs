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
    public partial class admin_page : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public admin_page()
        {
            InitializeComponent();
        }
        private void Manage_Load(object sender, EventArgs e)
        {
            Admin_txt.Text = manage_app.AdminEmail;
        }

        private void admin_page_Activated(object sender, EventArgs e)
        {
            Admin_txt.Text = manage_app.AdminEmail;
        }

        private void load_button_Click(object sender, EventArgs e)
        {

            string cmdstr = "";

            if (customer_radio.Checked)
            {
                cmdstr = "select * from customers";

            }
            else if (room_radio.Checked)
            {
                cmdstr = "select * from rooms";
            }
            else if (hotel_radio.Checked)
            {
                cmdstr = "select * from hotels";

            }
            adapter = new OracleDataAdapter(cmdstr, manage_app.ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            Grid_view.DataSource = ds.Tables[0];
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated Succesfully");
        }
        private void log_out_Click(object sender, EventArgs e)
        {
            Grid_view.DataSource = null;
            manage_app.login.Show();
            this.Hide();
        }

        private void show_reports_btn_Click(object sender, EventArgs e)
        {
            
            manage_app.reports.Show();
            this.Hide();
        }

        private void admin_page_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

      
    }
}
