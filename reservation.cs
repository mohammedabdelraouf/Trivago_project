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
    public partial class reservation : Form
    {
        int number_of_reservations;
        int room_price = 0;
        int total_cost = 0;
        int days = 0;  

        OracleConnection conn;
        public reservation()
        {
            InitializeComponent();
        }


        private void reservation_Load(object sender, EventArgs e)
        {
          
            conn = new OracleConnection(manage_app.ordb);
            conn.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandType = CommandType.Text;
            c.CommandText = "select hotelname from hotels";
            OracleDataReader dr = c.ExecuteReader();

            while (dr.Read())
            {
                hotels_cmb.Items.Add(dr[0]);
            }
            dr.Close();

            price_txt.Text = "$";
        }

        private void viewMyReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangeReservation c = new ChangeReservation();
            c.Show();
            this.Hide();
        }

        private void viewMyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust_Email.Text = manage_app.customer_email;
            cust_phone.Text = manage_app.customer_phone;
            cust_ID.Text = manage_app.customer_id;
            balance_txt.Text = manage_app.customer_balance.ToString();
            account_box.Visible = true;
        }



        private void hide_btn_Click(object sender, EventArgs e)
        {
            account_box.Visible = false;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            price_txt.Text = "$"; 
            rooms_cmb.Items.Clear();
            manage_app.login.Refresh();
            manage_app.login.Show();
            this.Hide();
        }

        private void show_rooms_btn_Click(object sender, EventArgs e)
        {
            rooms_cmb.Items.Clear();
            if (end_date.Value < start_date.Value)
            {
                MessageBox.Show("please choose valid end date ");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
               
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select rooms.roomnum , rooms.roomtype from   rooms where rooms.hotelname= :hotel  ";
                cmd.Parameters.Add("hotel", hotels_cmb.SelectedItem.ToString());


                OracleDataReader d = cmd.ExecuteReader();

                while (d.Read())
                {
                    if (d[1].ToString() == "Not Reserved")
                    {

                        rooms_cmb.Items.Add(d[0]);
                    }
                    else if (d[1].ToString() == "Reserved")
                    {
                        bool av = false;
                        OracleCommand cmd2 = new OracleCommand();
                        cmd2.Connection = conn;
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "select res.startdate , res.enddate from   reservation res  where res.roomnum= :n  ";
                        cmd2.Parameters.Add("n", d[0].ToString());

                        OracleDataReader dr = cmd2.ExecuteReader();
                        while (dr.Read())
                        {
                            if (Convert.ToDateTime(dr[0].ToString()) > end_date.Value || Convert.ToDateTime(dr[1].ToString()) < start_date.Value)

                            {
                                av = true;
                            }
                            else
                            {
                                av = false;
                                break;
                            }

                        }
                        if (av)
                        {
                            
                            rooms_cmb.Items.Add(d[0]);
                        }
                        dr.Close();
                    }
                }
                d.Close();
            }
        }

        private void rooms_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select price , RESERVATION_NUMBER from rooms 
                                 where roomnum=:num   ";
            cmd.Parameters.Add("num", rooms_cmb.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                days = (end_date.Value - start_date.Value).Days; 
                room_price = Convert.ToInt32(dr[0].ToString());
                total_cost = room_price * days;
                price_txt.Text = room_price.ToString() + "$";
                cost_txt.Text = total_cost.ToString() + "$";
                number_of_reservations = Convert.ToInt32(dr[1].ToString());
            }
            dr.Close();
            
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

           
            int  rid,  new_rid ;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_rid";
            cmd.Parameters.Add("rid", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();
            try
            {
                rid = Convert.ToInt32(cmd.Parameters["rid"].Value.ToString());
                new_rid = rid + 1;
            }
            catch
            {
                new_rid = 1;
            }



            if (rooms_cmb.Text == "")
            {
                MessageBox.Show("please choose a room ");
            }
            else
            {
                if (total_cost > manage_app.customer_balance)
                {
                    MessageBox.Show("your balance is not sufficiant please charage and try again");
                }
                else
                {

                    manage_app.customer_balance = manage_app.customer_balance - total_cost;
                    OracleCommand Update_balance = new OracleCommand();
                    Update_balance.Connection = conn;
                    Update_balance.CommandType = CommandType.Text;
                    Update_balance.CommandText = "update customers set cridit = :n where CUSTOMERID = :ci";
                    Update_balance.Parameters.Add("n", manage_app.customer_balance);
                    Update_balance.Parameters.Add("ci", manage_app.customer_id);

                    Update_balance.ExecuteNonQuery();

                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "INSERT_RESERVATION";
                    //customer_id in NUMBER,  reserv_id  in number  , room_num in number ,start_date in DATE , end_date in DATE
                    cmd2.Parameters.Add("cid", Convert.ToInt32(manage_app.customer_id));
                    cmd2.Parameters.Add("rid", new_rid);
                    cmd2.Parameters.Add("room_num", Convert.ToInt32(rooms_cmb.SelectedItem.ToString()));
                    cmd2.Parameters.Add("start_date", Convert.ToDateTime(start_date.Text));
                    cmd2.Parameters.Add("end_date", Convert.ToDateTime(end_date.Text));
                    cmd2.Parameters.Add("total_cost" , total_cost);
                    cmd2.ExecuteNonQuery();

                    OracleCommand cmd3 = new OracleCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.CommandText = "update_room_type";
                    cmd3.Parameters.Add("r", Convert.ToInt32(rooms_cmb.SelectedItem.ToString()));
                    cmd3.ExecuteNonQuery();

                    OracleCommand cmd4 = new OracleCommand();
                    cmd4.Connection = conn;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "update rooms set RESERVATION_NUMBER= :n Where roomnum = :n2 ";
                    cmd4.Parameters.Add("n", number_of_reservations + 1);
                    cmd4.Parameters.Add("n2", rooms_cmb.SelectedItem.ToString());

                    cmd4.ExecuteNonQuery();


                    MessageBox.Show("success");
                    hotels_cmb.Text = "";
                    rooms_cmb.Text = "";
                    rooms_cmb.Items.Clear();
                }
            }
        }


       
        private void reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            Application.Exit();
        }

        
    }
}
