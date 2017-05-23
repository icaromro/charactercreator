using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Data.Interface.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Repository
{
    public class ScaleRepository : BaseRepository<Scale>, IScaleRepository
    {
        public void Add(Scale obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Scale obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(Scale obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public Scale GetById(long id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllDataTable()
        {           
            string sql = @"SELECT * FROM scale ";
            DataTable dataTableScale = ObterDataTable(sql, null);
            if (dataTableScale.Rows.Count > 0)
                return dataTableScale;
            else            
                return new DataTable();                       
        }

        public List<Scale> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
