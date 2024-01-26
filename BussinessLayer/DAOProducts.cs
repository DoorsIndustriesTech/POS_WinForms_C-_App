using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;
using MySql.Data.MySqlClient;

namespace BussinessLayer
{
    public class DAOProducts
    {
        private dbConnection conn;
        private string sqlString;
        private MySqlCommand cmd;
        public bool validateData (DTOProduct dtoProduct)
        {
            bool res = true;
            if (dtoProduct.name == string.Empty)
            {
                MessageBox.Show("Product name is required");
                res = false;
            } else if (dtoProduct.price <= 0)
            {
                MessageBox.Show("Product price must be up to 0");
                res = false;
            }
            return res;
        }
        public void insertProduct(DTOProduct product)
        {
            conn = new dbConnection();
            try
            {
                if (conn.openConnection()) {
                    bool valid = validateData(product);
                    if (valid)
                    {
                        sqlString = "INSERT INTO product (name, price) VALUES (@txtName, @txtPrice);";
                        cmd = conn.queryStmt(sqlString);
                        cmd.Parameters.AddWithValue("@txtName", product.name);
                        cmd.Parameters.AddWithValue("@txtPrice", product.price);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product" + product.name + "added successfully!!");
                    }
                    conn.closeConnection();
                } else
                {
                    MessageBox.Show("Connection Error");
                }
            } catch (MySqlException ex) {
                MessageBox.Show("Can't insert Product" + ex.Message);
            }
        }
    }
}
