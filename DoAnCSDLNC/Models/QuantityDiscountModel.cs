using DoAnCSDLNC.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSDLNC.Models
{
    class QuantityDiscountModel
    {
        public DataTable getAllQuantityDiscount()
        {
            string sql = "SELECT* FROM tbQuantityDiscount";
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            try
            {
                connection = new ConnectDB().connectToSQL();
                adapter.SelectCommand = new SqlCommand(sql, connection);
                adapter.Fill(dataset);
            }
            catch(Exception)
            {
                throw;
            }
            connection.Close();
            return dataset.Tables[0];
        }

        public bool insertQuantityDiscount(QuantityDiscount discount)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO tbQuantityDiscount VALUES(" + discount.MinQuantity + ", " + discount.MaxQuantity + ", " + discount.DiscountRate + ")";
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if(command.ExecuteNonQuery() == 1)
                {
                    inserted = true;
                }                
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return inserted;
        }

        public int getInsertefdId()
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT TOP 1 DiscountId FROM tbQuantityDiscount ORDER BY DiscountId DESC";
            try
            {
                connection = new ConnectDB().connectToSQL();
                adapter.SelectCommand = new SqlCommand(sql, connection);
                adapter.Fill(dataset);
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return int.Parse(dataset.Tables[0].Rows[0][0].ToString());
        }

        public bool updateQuantityDiscount(QuantityDiscount quantityDiscount)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "UPDATE tbQuantityDisCount SET MinQuantity = " + quantityDiscount.MinQuantity + ", MaxQuantity = " + quantityDiscount.MaxQuantity + ", Discount = " + quantityDiscount.DiscountRate + " WHERE DiscountId = " + quantityDiscount.DiscountId;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    updated = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return updated;
        }

        public bool deleteQuantityDiscount(int discountId)
        {
            bool deleted = false;
            string sql = "DELETE FROM tbQuantityDisCount WHERE DiscountId = " + discountId;
            SqlConnection connection;
            SqlCommand command;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    deleted = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return deleted;
        }
    }
}
