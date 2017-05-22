using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Data.Interface.Repository;

namespace CharCreator.Data.Repository
{
    public class SystemRepository : BaseRepository<Model.Entity.System>, ISystemRepository
    {
        public void Add(Model.Entity.System obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Model.Entity.System obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model.Entity.System obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public List<Model.Entity.System> GetAll()
        {
            List<Model.Entity.System> systemList = new List<Model.Entity.System>();
            
            string sql = @"SELECT * FROM system ";                        

            DataTable dataTableSystem = ObterDataTable(sql, null);
            Model.Entity.System system;
            foreach (DataRow dataRowsSystem in dataTableSystem.Rows)
            {
                system = new Model.Entity.System();
                system.LoadSystem(dataRowsSystem);
                systemList.Add(system);
            }
            
            return systemList;
        }

        public Model.Entity.System GetById(long id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllActive()
        {            
            string sql = @"SELECT id, name FROM system WHERE active = 1";

            DataTable dataTableSystem = ObterDataTable(sql, null);
            if (dataTableSystem.Rows.Count > 0)
                return dataTableSystem;            
            return new DataTable();
        }
    }
}
