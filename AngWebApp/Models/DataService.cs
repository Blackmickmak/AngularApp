using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace AngWebApp.Models
{
    public class DataService
    {
        public MySqlConnection con = null;
        public MySqlCommand cmd = null;
        public MySqlDataReader sdr = null;
        private bool success = false;

        public DataService()
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Database=classicmodels;Uid=root;Pwd=database1;");
            }
            catch (Exception ex)
            {

            }
           

        }

        public bool Open()
        {
            try
            {
                if ( con.State == 0)
                {
                    con.Open();
                    success = true;
                }  
            }
            catch (Exception ex)
            {
                success = false;
            }
             
            return success;
        }

        public bool Close()
        {
            try
            {
                if (con.State == ConnectionState.Open )
                {
                    con.Close() ;
                    success = true;
                }
            }
            catch (Exception ex)
            {
                success = false;
            }

            return success;
        }
    }
}
