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
    class CustomerModel
    {
        public DataTable getAllCustomer()
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT* FROM tbCustomer ORDER BY CustomerId DESC";
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

        public DataTable getCustomerByPhoneNumber(string phoneNumber)
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT* FROM tbCustomer WHERE PhoneNumber = " + phoneNumber;
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

        public bool insertCustomer(Customer customer)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO tbCustomer VALUES (N'" + customer.Name;
            sql += "', CONVERT(DATE, '" + customer.Dob + "', 103),";
            sql += " '" + customer.PhoneNumber + "', '" + customer.Identification + "', '" + customer.AccountNumber + "', N'" + customer.Address + "')";
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

        public int getInsertedId()
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT TOP 1 CustomerId FROM tbCustomer ORDER BY CustomerId DESC";
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

        public bool updateCustomer(Customer customer)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "UPDATE tbCustomer SET Name = N'" + customer.Name;
            sql += "', DOB = CONVERT(DATE, '" + customer.Dob + "', 103),";
            sql += " PhoneNumber = '" + customer.PhoneNumber;
            sql += "', Identification = '" + customer.Identification;
            sql += "', AccountNumber = '" + customer.AccountNumber + "', Address = N'" + customer.Address;
            sql += "' WHERE CustomerId = " + customer.CustomerId;
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

        public bool deleteCustomer(int customerId)
        {
            bool deleted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "DELETE FROM tbCustomer WHERE CustomerId = " + customerId;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() >= 1)
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
