using DataAccess.Absolute;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public class DatabaseManager : IDatabaseManager
    {
        // Connection string can be stored in a configuration file for better portability.
        // For example, in App.config or Web.config.
        //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:" +
        //   "\\Users\\31766\\source\\repos\\Calculator\\DataAccess\\Database1.mdf;Integrated Security=True";
        string connectionString = "Server = localhost,1433; Database=Dataset;User=sa;Password=Alperkaan11";

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public void SaveToDatabase(DateTime resultDate, string resultHistory, string result)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO HistoryTable (resultDate, resultHistory, result) VALUES (@resultDate, @resultHistory, @result)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@resultDate", resultDate.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@resultHistory", resultHistory);

                        if (double.TryParse(result, out double doubleResult))
                        {
                            command.Parameters.AddWithValue("@result", doubleResult);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@result", result);
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı işlem hatası: " + ex.Message);
            }
        }

        public DataTable GetHistoryData()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string selectQuery = "SELECT resultDate as Tarih, resultHistory as İşlem, result as Sonuç FROM HistoryTable";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Veritabanı bağlantı hatası: " + ex.Message);
            }
        }

        public void ClearHistory()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM HistoryTable";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Veritabanı işlem hatası: " + ex.Message);
            }
        }

        public void DeleteLastEntry()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM HistoryTable WHERE ID = (SELECT MAX(ID) FROM HistoryTable)";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Veritabanı işlem hatası: " + ex.Message);
            }
        }
    }
}
