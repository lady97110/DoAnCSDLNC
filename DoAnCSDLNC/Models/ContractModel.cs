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
    class ContractModel
    {
        public int getQuantityDiscout(int quantity)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = "dbo.spGetQuantityDiscount";
            int result;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                SqlParameter quantityParameter = new SqlParameter("@quantity", SqlDbType.Int);
                SqlParameter outputParameter = new SqlParameter("@quantityDiscount", SqlDbType.Int);
                quantityParameter.Direction = ParameterDirection.Input;
                quantityParameter.Value = quantity;
                outputParameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(quantityParameter);
                command.Parameters.Add(outputParameter);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                result = int.Parse(outputParameter.Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return result;
        }

        public bool insertContract(Contract contract)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO dbo.tbContract(CustomerID, TourID, DraftDate, TerminationDate, StartTime, Quantity, QuantityDiscount, TotalMoney, Deposit, Note) VALUES(";
            sql += contract.CustomerId;
            sql += ", " + contract.TourId + ", ";
            sql += "GETDATE(),";
            sql += "CONVERT(DATETIME, '" + contract.TemimationDate + "', 103), ";
            sql += "CONVERT(DATETIME, '" + contract.StartTime + "', 103), ";
            sql += contract.Quantity + ", 0, " + contract.TotalMoney + "," + contract.Deposit + ", N'" + contract.Note + "')";
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() >= 1)
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
            string sql = "SELECT TOP 1 ContractId FROM tbContract ORDER BY ContractId DESC";
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

        public bool updateContract(Contract contract)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql="";
            if(contract.State == 0)
            {
                sql = "UPDATE tbContract SET Quantity = " + contract.Quantity;
                sql += ", Deposit = " + contract.Deposit;
                sql += ", Note = N'" + contract.Note + "' WHERE ContractId = " + contract.ContracId;
            }
            //if (contract.State == 1)
            //{
            //    sql = "UPDATE tbContract SET State = 1 WHERE ContractId = " + contract.ContracId;
            //}
            if (contract.State == 2)
            {
                sql = "UPDATE tbContract SET State = 2 WHERE ContractId = " + contract.ContracId;
            }
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() >= 1)
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

        public DataTable getValidContract()
        {
            string sql = "SELECT* FROM tbContract WHERE TerminationDate >= GETDATE() and State = 1";
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

        public int getRefundRate(int contractId)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = "dbo.spGetRefundRate";
            int result;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                SqlParameter contractIdParameter = new SqlParameter("@contractId", SqlDbType.Int);
                SqlParameter outputParameter = new SqlParameter("@refundRate", SqlDbType.TinyInt);
                contractIdParameter.Direction = ParameterDirection.Input;
                contractIdParameter.Value = contractId;
                outputParameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(contractIdParameter);
                command.Parameters.Add(outputParameter);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                result = int.Parse(outputParameter.Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return result;
        }
    }
}
