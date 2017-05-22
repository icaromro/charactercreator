using System.Collections.Generic;
using System.Data.Common;

namespace CharCreator.Data.Interface.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj, DbTransaction transaction = null);
        void Update(TEntity obj, DbTransaction transaction = null);
        void Delete(TEntity obj, DbTransaction transaction = null);
        List<TEntity> GetAll();
        TEntity GetById(long id);
    }
}
