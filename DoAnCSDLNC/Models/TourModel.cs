using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DoAnCSDLNC.Shared;
using DoAnCSDLNC.Classes;

namespace DoAnCSDLNC.Models
{
    class TourModel
    {
        public DataTable getAllTour()
        {
            string sql = "SELECT* FROM tbTour ORDER BY TourId DESC";
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

        public DataTable getValidTour()
        {
            string sql = "SELECT* FROM tbTour WHERE StartDate > GETDATE() AND EmptySeat > 0 ORDER BY StartDate ASC";
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

        public DataTable getValidTourWhere(List<string> whereArgs)
        {
            string sql = "SELECT* FROM tbTour";
            if (whereArgs[0].ToLower() == "true")
            {
                sql += " WHERE StartLocation LIKE N'" + whereArgs[1] + "' AND Destination LIKE N'" + whereArgs[2] + "'";
            }
            //if (whereArgs[3].ToLower() == "true")
            //{
            //    if (sql.Contains("WHERE"))
            //    {
            //        sql += " AND StartDate >= CONVERT(DATE, '" + whereArgs[4] + "', 103) AND EndDate <= CONVERT(DATE, '" + whereArgs[5] + "', 103)";
            //    }
            //    else
            //    {
            //        sql += " WHERE StartDate >= CONVERT(DATE, '" + whereArgs[4] + "', 103) AND EndDate <= CONVERT(DATE, '" + whereArgs[5] + "', 103)";
            //    }
            //}
            if (whereArgs[6].ToLower() == "true")
            {
                if (sql.Contains("WHERE"))
                {
                    sql += " AND Price >= " + Utils.eraiseComma(whereArgs[7]) + " AND Price <= " + Utils.eraiseComma(whereArgs[8]);
                }
                else
                {
                    sql += " WHERE Price >= " + Utils.eraiseComma(whereArgs[7]) + " AND Price <= " + Utils.eraiseComma(whereArgs[8]);
                }
            }
            sql += " AND StartDate > CONVERT(DATE, '" + DateTime.Now + "', 103) ORDER BY StartDate ASC";
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

        public bool insertTour(Tour tour)
        {
            bool inserted = false;
            string sql = "INSERT INTO tbTour VALUES (N'" + tour.StartLocation;
            sql += "', N'" + tour.Destination;
            sql += "', '" + tour.StartDate + "', ";
            sql += "'" + tour.EndDate + "',";
            sql +=" " + tour.TotalSeat + ", " + tour.EmptySeat + ", " + tour.Price + ")";
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

        public int getInsertedId()
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT TOP 1 TourId FROM dbo.tbTour ORDER BY TourId DESC";
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

        public bool updateTour(Tour tour)
        {
            bool updated = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "UPDATE tbTour SET StartLocation = N'" + tour.StartLocation;
            sql += "', Destination = N'" + tour.Destination;
            sql += "', StartDate = CONVERT(DATE, '" + tour.StartDate + "', 103)";
            sql += ", EndDate = CONVERT(DATE, '" + tour.EndDate + "', 103)";
            sql += ", TotalSeat = " + tour.TotalSeat + ", EmptySeat = " + tour.EmptySeat + ", Price = " + tour.Price;
            sql += " WHERE TourId = " + tour.TourId;
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

        public bool deleteTour(int tourId)
        {
            bool deleted = false;
            SqlConnection connection;
            SqlCommand command;
            string sql = "DELETE FROM tbTour WHERE TourId = " + tourId;
            try
            {
                connection = new ConnectDB().connectToSQL();
                command = new SqlCommand(sql, connection);
                if (command.ExecuteNonQuery() > 1)
                {
                    deleted = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            connection.Close();
            return deleted;
        }

        public int getPriceTourByContractId(int contractId)
        {
            SqlConnection connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT Price FROM dbo.tbContract INNER JOIN dbo.tbTour ON tbTour.TourId = tbContract.TourId WHERE ContractId = " + contractId;
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
    }
}
