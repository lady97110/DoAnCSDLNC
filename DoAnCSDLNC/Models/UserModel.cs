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
    class UserModel
    {
        public DataTable getUser(User user)
        {
            string sql = "SELECT* FROM tbUsers WHERE UserName = N'" + user.UserName + "' AND Password = N'" + user.Password + "'";
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

        public DataTable getUserByName(User user)
        {
            string sql = "SELECT* FROM tbUsers WHERE UserName = N'" + user.UserName + "'";
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

        public bool insertUser(User user)
        {
            bool inserted = false;
            string sql = "INSERT INTO tbUsers VALUES(N'" + user.UserName + "', N'" + user.Password + "', " + user.UserType + ")";
            SqlConnection connection;
            SqlCommand command;
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
    }
}
