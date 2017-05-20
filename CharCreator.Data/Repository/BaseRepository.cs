using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace CharCreator.Data.Repository
{
    public class BaseRepository<TEntity>  where TEntity : class
    {
        protected readonly SqlConnection DataBaseConnection;

        public BaseRepository()
        {
            DataBaseConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase_Dev"].ConnectionString);
        }

        private void OpenConnection()
        {
            DataBaseConnection.Open();
        }

        private void CloseConnection()
        {
            DataBaseConnection.Close();
        }

        public DataTable ObterDataTable(string sql, Hashtable parametros, DbTransaction transaction = null)
        {
            DataTable dataTableReturn = new DataTable();

            OpenConnection();
            SqlCommand command = new SqlCommand(sql, DataBaseConnection);

            foreach (DictionaryEntry entry in parametros)
            {
                command.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);
            }            

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            CloseConnection();
            try
            {                
                int rowsReturned = dataAdapter.Fill(dataTableReturn);
                if (rowsReturned == 0)                
                    dataTableReturn = new DataTable();                    
            }
            catch
            {
                dataTableReturn = new DataTable();
            }
            return dataTableReturn;
        }

        public bool ExecuteQuery(string sql, Hashtable parametros, DbTransaction transaction = null)
        {
            OpenConnection();

            SqlCommand command = new SqlCommand(sql, DataBaseConnection);
            foreach (DictionaryEntry entry in parametros)
            {
                command.Parameters.AddWithValue(entry.Key.ToString(), entry.Value);
            }
            //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
            SqlDataAdapter sda = new SqlDataAdapter(command);
            //SqlDataReader reader = command.ExecuteReader();
            try
            {
                DataTable dt = new DataTable();
                int rows_returned = sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    CloseConnection();
                    return true;
                }
                //while (reader.Read())                
                //Console.WriteLine(String.Format("{0}, {1}", reader["tPatCulIntPatIDPk"], reader["tPatSFirstname"]));// etc

            }
            catch 
            {
                CloseConnection();
                return false;
            }
            finally
            {
                // Always call Close when done reading.
                //reader.Close();
            }
            return false;            
        }

    }
}
