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
    class MemberModel
    {

        public int getAgeDiscout(DateTime DOB)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = "dbo.spGetAgeDiscount";
            int result;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                SqlParameter quantityParameter = new SqlParameter("@DOB", SqlDbType.Date);
                SqlParameter outputParameter = new SqlParameter("@ageDiscount", SqlDbType.TinyInt);
                quantityParameter.Direction = ParameterDirection.Input;
                quantityParameter.Value = DOB;
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

        public bool insertMember(Member member)
        {
            bool inserted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "INSERT INTO tbMember(ContractId, Name, DOB, Identification, AgeDiscount, MemberPrice) VALUES(";
            sql += member.ContracId;
          //  sql += ", " + member.MemberId;
            sql += ", N'" + member.Name;
            sql += "','" + member.Dob + "','" + member.Identification + "',";
            sql += member.AgeDiscount + "," + member.MemberPrice + ")";
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

        public DataTable getMemberByContractId(int contractId)
        {
            string sql = "SELECT* FROM tbMember WHERE ContractId = " + contractId;
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

        public bool UpdateMemberByContractId(Member member)
        {
            string sql = "UPDATE dbo.tbMember SET Name = N'" + member.Name;
            sql += "', DOB = '" + member.Dob + "',Identification = '" + member.Identification + "' WHERE ContractID = ";
            sql += member.ContracId + "AND MemberID = " + member.MemberId;
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() != 0)
                {
                    updated = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return updated;
        }
    }
}
