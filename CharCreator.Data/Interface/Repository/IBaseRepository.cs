using System.Collections.Generic;

namespace CharCreator.Data.Interface.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        List<TEntity> GetAll();
        TEntity GetById(long id);
    }
}
