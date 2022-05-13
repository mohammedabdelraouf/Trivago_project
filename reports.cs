using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace trivago
{

    public partial class reports : Form
    {
        CrystalReport1 cr;
        CrystalReport2 cr2;
        public reports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            cr2 = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                cmb_hotel.Items.Add(v.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (cmb_hotel.Text == "")
                MessageBox.Show("Please choose hotel name");
            else
            {
                cr.SetParameterValue(0, cmb_hotel.Text);
               crystalReportViewer1.ReportSource = cr;
            }

        }


        private void btn_customers_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            manage_app.admin_Page.Show();
            this.Hide();
        }

        private void reports_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();
        }
    }
}
