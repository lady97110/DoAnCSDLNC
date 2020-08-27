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
    class AgeDiscountModel
    {
        public DataTable getAllAgeDiscount()
        {
            string sql = "SELECT* FROM tbAgeDiscount";
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
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
            return dataset.Tables[0];
        }

        public bool insertAgeDiscount(AgeDiscount discount)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO tbAgeDiscount VALUES(" + discount.MinAge + ", " + discount.MaxAge + ", " + discount.DiscountRate + ")";
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() == 1)
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
            string sql = "SELECT TOP 1 DiscountId FROM tbAgeDiscount ORDER BY DiscountId DESC";
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

        public bool updateAgeDiscount(AgeDiscount AgeDiscount)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "UPDATE tbAgeDiscount SET MinAge = " + AgeDiscount.MinAge + ", MaxAge = " + AgeDiscount.MaxAge + ", Discount = " + AgeDiscount.DiscountRate + " WHERE DiscountId = " + AgeDiscount.DiscountId;
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

        public bool deleteAgeDiscount(int discountId)
        {
            bool deleted = false;
            string sql = "DELETE FROM tbAgeDiscount WHERE DiscountId = " + discountId;
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
