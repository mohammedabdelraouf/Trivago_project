using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trivago
{

   public static class  manage_app
    {
        public static registeration registeration = new registeration();
        public static login login = new login();
        public static reservation reservation = new reservation();
        public static admin_page admin_Page = new admin_page();
        public static ChangeReservation changeReservation = new ChangeReservation();
        public static reports reports = new reports();
        // current user data 
        public static string customer_name;
        public static string customer_id;
        public static string customer_phone;
        public static string customer_email;
        public static int customer_balance; 
        // current admin data
        public static string admin_name;
        public static string admin_id;
        public static string AdminEmail;

        // oracel database connection string
       public static string ordb = "Data source=orcl; User Id = hr ; Password = hr ;";



    }
}
