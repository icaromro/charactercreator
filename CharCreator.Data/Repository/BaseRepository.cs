using CharCreator.Domain.Interface.Repository;
using System.Data.SqlClient;
using System.Configuration;

namespace CharCreator.Data.Repository
{
    public class BaseRepository<TEntity>  where TEntity : class
    {
        protected readonly SqlConnection DataBaseConnection;

        public BaseRepository()
        {
            DataBaseConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase_Dev"].ConnectionString);
        }

        public void OpenConnection()
        {
            DataBaseConnection.Open();
        }

        public void CloseConnection()
        {
            DataBaseConnection.Close();
        }
        
    }
}
