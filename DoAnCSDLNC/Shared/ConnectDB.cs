using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnCSDLNC
{
    class ConnectDB
    {
        public SqlConnection connectToSQL(){
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=ladynuce;Initial Catalog=DoAnCSDLNC;Persist Security Info=True;User ID=sa;Password=123456";
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
            }
            catch(Exception)
            {
                throw;
            }
            return cnn;
        }
    }
}
