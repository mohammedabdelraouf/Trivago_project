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
    public partial class ChangeReservation : Form
    {
        string roomnum = "";
        int total_cost;

        OracleConnection conn;
        public ChangeReservation()
        {
            InitializeComponent();
        }

        public void Loaddata()
            {

            // disconected mode  load data 
            //manage_app.customer_id = "1";
            OracleDataAdapter adapter;
            DataSet ds;

            string cmdstr = "select RESERVID , ROOMNUM,STARTDATE, enddate  , RATES from reservation where CUSTOMERID = :d";
            adapter = new OracleDataAdapter(cmdstr, manage_app.ordb);
            adapter.SelectCommand.Parameters.Add("d", manage_app.customer_id);
            ds = new DataSet();
            adapter.Fill(ds);
            res_data.DataSource = ds.Tables[0];


                //********************************************************************************************



            conn = new OracleConnection(manage_app.ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETROOMNUM";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", manage_app.customer_id);
            cmd.Parameters.Add("rooms", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                room_cmb.Items.Add(dr[0]);
            }
            dr.Close();

            }
        private void ChangeReservation_Load(object sender, EventArgs e)
        {

            Loaddata();
        }
        private void room_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomnum = room_cmb.SelectedItem.ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMoreInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("room", room_cmb.SelectedItem.ToString());
            cmd.Parameters.Add("price", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("hotel", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            hotel_txt.Text = cmd.Parameters["hotel"].Value.ToString();
            price_txt.Text = cmd.Parameters["price"].Value.ToString() + "$";


            resid_cmb.Items.Clear();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandType = CommandType.Text;
            c.CommandText = "select RESERVID from reservation Where CUSTOMERID = :d  and roomnum=:x";
            c.Parameters.Add("d", manage_app.customer_id);
            c.Parameters.Add("x" , Convert.ToInt32(room_cmb.SelectedItem));
            OracleDataReader d = c.ExecuteReader();
            while (d.Read())
            {
                resid_cmb.Items.Add(d[0]);
            }
            d.Close();
        }



        private void resid_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getcost";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("rid", resid_cmb.SelectedItem.ToString());
            cmd.Parameters.Add("t", OracleDbType.Decimal).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            total_cost_txt.Text = cmd.Parameters["t"].Value.ToString();


        }

        private void delete_buttun_Click(object sender, EventArgs e)
        {
            if (roomnum != "")
            {
                int n = 1;
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandType = CommandType.Text;
                c.CommandText = "select RESERVATION_NUMBER from rooms where roomnum = :room";
                c.Parameters.Add("room", Convert.ToInt32(room_cmb.SelectedItem.ToString()));
                OracleDataReader dr = c.ExecuteReader();

                while (dr.Read())
                {
                    try
                    {
                        n = Convert.ToInt32(dr[0].ToString());
                    }
                    catch
                    {
                        n = 1;
                    }
                }


                if (n > 1)
                {
                    n--;
                    update_function(1, n);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE  RESERVATION WHERE roomnum = :roomn  and RESERVID = :i";
                    cmd.Parameters.Add("roomn", Convert.ToInt32(room_cmb.SelectedItem.ToString()));
                    cmd.Parameters.Add("i", Convert.ToInt32(resid_cmb.SelectedItem.ToString()));
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {

                        MessageBox.Show("deleted succesfully");
                    }
                    else
                    {
                        MessageBox.Show("not successfully deleted");
                    }
                }
                else if (n == 1)
                {
                    n--;
                    update_function(0, n);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE from RESERVATION WHERE roomnum = :roomn  and RESERVID = :i";
                    cmd.Parameters.Add("roomn", Convert.ToInt32(room_cmb.SelectedItem.ToString()));
                    cmd.Parameters.Add("i", Convert.ToInt32(resid_cmb.SelectedItem.ToString()));
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        total_cost= Convert.ToInt32(total_cost_txt.Text);
                        manage_app.customer_balance = manage_app.customer_balance +total_cost ;
                        OracleCommand Update_balance = new OracleCommand();
                        Update_balance.Connection = conn;
                        Update_balance.CommandType = CommandType.Text;
                        Update_balance.CommandText = "update customers set cridit = :n where CUSTOMERID = :ci";
                        Update_balance.Parameters.Add("n", manage_app.customer_balance);
                        Update_balance.Parameters.Add("ci", manage_app.customer_id);

                        Update_balance.ExecuteNonQuery();

                        MessageBox.Show("deleted succesfully");


                        // reload data after update 

                        room_cmb.Items.Clear();
                        resid_cmb.Items.Clear();
                        room_cmb.Text = "";
                        resid_cmb.Text = "";


                        Loaddata();

                        //***************************************************************************************//
                    }
                    else
                    {
                        MessageBox.Show("not successfully deleted");
                    }
                }

               
            }
            else  // does not choose a room number
            { 
                MessageBox.Show("Please Select Room Number");
            }
        }
        private void ChangeReservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            
        }


        private void update_function(int i , int n )
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            if (i == 0)
            {  
                cmd.CommandText = "update rooms set roomtype= 'Not Reserved' , reservation_number = :n where roomnum = :room ";
                
            }
            else if (i==1)
            { 
                cmd.CommandText = "update rooms set RESERVATION_NUMBER = :n where roomnum = :roomn ";
               
            }
            cmd.Parameters.Add("n", n);
            cmd.Parameters.Add("room", room_cmb.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res_data.DataSource = null;
            manage_app.reservation.Show();
            manage_app.reservation.Focus();
            this.Hide();
        }

        private void ChangeReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            Application.Exit();
        }

        
    }
}
