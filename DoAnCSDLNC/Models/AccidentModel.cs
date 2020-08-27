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
    class AccidentModel
    {
        public DataTable getAccidentsByContract(int contractId)
        {
            string sql = "SELECT* FROM tbAccident WHERE ContractId = " + contractId + " ORDER BY AccidentId DESC";
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

        public bool insertAccident(Accident accident)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO tbAccident(ContractId, Accident, DraftDate, PayDamage) VALUES (" + accident.ContractId;
            sql += ", N'" + accident.AccidentName + "', GETDATE(), " + accident.PayDamage + ")";
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
            string sql = "SELECT TOP 1 AccidentId FROM tbAccident ORDER BY AccidentId DESC";
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

        public bool updateAccident(Accident accident)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "UPDATE tbAccident SET Accident = N'" + accident.AccidentName;
            sql += "', PayDamage = " + accident.PayDamage + " WHERE AccidentId = " + accident.AccidentId;
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

        public bool deleteAccident(Accident accident)
        {
            bool deleted = false;
            string sql = "DELETE FROM tbAccident WHERE AccidentId = " + accident.AccidentId;
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
