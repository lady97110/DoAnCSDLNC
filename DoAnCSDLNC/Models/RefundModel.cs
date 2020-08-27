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
    class RefundModel
    {
        public DataTable getAllRefund()
        {
            string sql = "SELECT* FROM tbRefund";
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

        public bool insertRefund(Refund refund)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO tbRefund VALUES(" + refund.MinDay + ", "+ refund.MaxDay +", " + refund.RefundRate + ")";
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

        public int getInsertedId()
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT TOP 1 RefundId FROM tbRefund ORDER BY RefundId DESC";
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

        public bool updateRefund(Refund refund)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "UPDATE tbRefund SET MinDay = " + refund.MinDay + ", MaxDay = " + refund.MaxDay + ", RefundRate = " + refund.RefundRate + " WHERE RefundId = " + refund.RefundId;
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

        public bool deleteRefund(int refundId)
        {
            bool deleted = false;
            string sql = "DELETE FROM tbRefund WHERE RefundId = " + refundId;
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
