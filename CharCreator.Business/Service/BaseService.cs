using CharCreator.Data.Repository;

namespace CharCreator.Business.Service
{
    public class BaseService<TEntity> where TEntity : class
    {
        private readonly BaseRepository<TEntity> _baseRepository;

        public BaseService()
        {
            _baseRepository = new BaseRepository<TEntity>();
        }
    }
}
