
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CharCreator.Domain.Interface.Repository
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
