using MySql.Data.MySqlClient;
using EntityLayer;
using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata.Ecma335;

namespace DataLayer
{
    public class dbConnection
    {
        private static string conString = "Server=localhost;User=root;Password=admin;Port=3306;database=wndcrud";

        MySqlConnection con = new MySqlConnection(conString);
        public bool openConnection()
        {
            try
            {
                con.Open();
                /* MessageBox.Show("Connected"); */
                return true;
            } catch ( MySqlException ex )
            {
                MessageBox.Show("Connection Failed" + ex.Message);
                return false;
            }
        }

        public MySqlCommand queryStmt(string queryString)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(queryString, con);
                return cmd;
            } 
            catch ( MySqlException ex )
            {
                MessageBox.Show("Command error" + ex.Message);
                return null;
            }
        }
        public void closeConnection()
        {
            try
            {
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Failed" + ex.Message);
                return;
            }
        }
    }
}